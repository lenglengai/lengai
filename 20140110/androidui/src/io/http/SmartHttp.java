package io.http;

import java.io.IOException;
import java.io.UnsupportedEncodingException;

import org.apache.http.HttpHost;
import org.apache.http.HttpResponse;
import org.apache.http.HttpVersion;
import org.apache.http.ParseException;
import org.apache.http.client.ClientProtocolException;
import org.apache.http.client.HttpClient;
import org.apache.http.client.methods.HttpPost;
import org.apache.http.client.params.HttpClientParams;
import org.apache.http.conn.params.ConnManagerParams;
import org.apache.http.conn.params.ConnPerRouteBean;
import org.apache.http.conn.params.ConnRoutePNames;
import org.apache.http.entity.StringEntity;
import org.apache.http.impl.client.DefaultHttpClient;
import org.apache.http.params.BasicHttpParams;
import org.apache.http.params.HttpConnectionParams;
import org.apache.http.params.HttpParams;
import org.apache.http.params.HttpProtocolParams;
import org.apache.http.protocol.HTTP;
import org.apache.http.util.EntityUtils;
import org.json.JSONException;

import common.startup.AppContext;
import common.utility.ErrorCode_;
import common.utility.Setting;
import serialize.json.IJsonHeadstream;
import serialize.json.JsonReader;
import serialize.json.JsonWriter;
import serialize.json.RequestResult;
import android.content.Context;
import android.net.ConnectivityManager;
import android.net.NetworkInfo;

public class SmartHttp {

	public static final RequestResult runPost(IJsonHeadstream nRequest, IJsonHeadstream nJsonRespone) {
		Setting setting = AppContext.getSetting();
		String host = setting.getHost();
    	String requestUrl = host + nRequest.streamName();
    	JsonWriter jsonWriter = new JsonWriter();
    	final HttpClient httpClient = SmartHttp.createHttpClient(AppContext.getAppContext());
    	HttpPost httpPost = new HttpPost(requestUrl);
		try {
			nRequest.headSerialize(jsonWriter);
			StringEntity stringEntity = new StringEntity(jsonWriter.getValue(), HTTP.UTF_8);
			httpPost.setEntity(stringEntity);
			httpPost.addHeader("Content-Type", "application/json");
			HttpResponse httpResponse = httpClient.execute(httpPost);
			int errorCode = httpResponse.getStatusLine().getStatusCode();
			if (errorCode == ErrorCode_.mHttpOk_) {
				String jsonString = EntityUtils.toString(httpResponse.getEntity(), HTTP.UTF_8);
				JsonReader jsonReader = new JsonReader(jsonString);
				nJsonRespone.headSerialize(jsonReader);
			}
			else {
				return new RequestResult(errorCode, httpResponse.getStatusLine().toString());
			}
		} catch (UnsupportedEncodingException e) {
			return new RequestResult(ErrorCode_.mEncoding_, e.getMessage());
		} catch (ClientProtocolException e) {
			return new RequestResult(ErrorCode_.mClientProtocol_, e.getMessage());
		} catch (IOException e) {
			return new RequestResult(ErrorCode_.mHttpIO_, e.getMessage());
		} catch (ParseException e) {
			return new RequestResult(ErrorCode_.mHttpParse_, e.getMessage());
		} catch (JSONException e) {
			return new RequestResult(ErrorCode_.mJson_, e.getMessage());
		}
		return new RequestResult(ErrorCode_.mSucess_, "");
    }
    
    public static final boolean isConnected(final Context context) {
        final ConnectivityManager connec = (ConnectivityManager) context
                .getSystemService(Context.CONNECTIVITY_SERVICE);
        final NetworkInfo info = connec.getActiveNetworkInfo();
        return (info != null) && info.isConnectedOrConnecting();
    }

    public static final boolean isNotConnected(final Context context) {
        return !SmartHttp.isConnected(context);
    }

    public static final boolean isWifi(final Context context) {
        final ConnectivityManager connec = (ConnectivityManager) context
                .getSystemService(Context.CONNECTIVITY_SERVICE);
        final NetworkInfo info = connec.getActiveNetworkInfo();
        return (info != null) && (info.getType() == ConnectivityManager.TYPE_WIFI);
    }
        
    static final DefaultHttpClient createHttpClient(final Context context) {
        final HttpParams params = SmartHttp.createHttpParams();
        final DefaultHttpClient client = new DefaultHttpClient(params);
        client.addRequestInterceptor(new GzipRequestInterceptor());
        client.addResponseInterceptor(new GzipResponseInterceptor());
        client.setHttpRequestRetryHandler(new RequestRetryHandler(
        		SmartHttp.MAX_RETRY_TIMES));
        SmartHttp.checkAndSetProxy(context, params);
        return client;
    }
    
    static final HttpParams createHttpParams() {
        final HttpParams params = new BasicHttpParams();
        
		Setting setting = AppContext.getSetting();
		String versionName = setting.getVersionName();
		
        HttpProtocolParams.setUseExpectContinue(params, false);
        HttpProtocolParams.setContentCharset(params, HTTP.UTF_8);
        HttpProtocolParams.setVersion(params, HttpVersion.HTTP_1_1);
        
        ConnManagerParams.setTimeout(params, SmartHttp.SOCKET_TIMEOUT_MS);
        
        HttpConnectionParams.setConnectionTimeout(params, SmartHttp.CONNECTION_TIMEOUT_MS);
        HttpConnectionParams.setSoTimeout(params, SmartHttp.SOCKET_TIMEOUT_MS);

        ConnManagerParams.setMaxConnectionsPerRoute(params, new ConnPerRouteBean(SmartHttp.MAX_TOTAL_CONNECTIONS));
        ConnManagerParams.setMaxTotalConnections(params, SmartHttp.MAX_TOTAL_CONNECTIONS);

        HttpConnectionParams.setStaleCheckingEnabled(params, false);
        HttpConnectionParams.setTcpNoDelay(params, true);
        HttpConnectionParams.setSocketBufferSize(params, SmartHttp.SOCKET_BUFFER_SIZE);
        
        HttpClientParams.setRedirecting(params, false);
        
        HttpProtocolParams.setUserAgent(params, "lengai for Android/" + versionName);
        return params;
    }
    
    static final void checkAndSetProxy(final Context context, final HttpParams httpParams) {
        boolean needCheckProxy = true;

        final ConnectivityManager cm = (ConnectivityManager) context
                .getSystemService(Context.CONNECTIVITY_SERVICE);
        final NetworkInfo networkInfo = cm.getActiveNetworkInfo();
        if ((networkInfo == null)
                || SmartHttp.WIFI.equalsIgnoreCase(networkInfo.getTypeName())
                || (networkInfo.getExtraInfo() == null)) {
            needCheckProxy = false;
        }
        if (needCheckProxy) {
            final String typeName = networkInfo.getExtraInfo();
            if (SmartHttp.MOBILE_CTWAP.equalsIgnoreCase(typeName)) {
                final HttpHost proxy = new HttpHost("10.0.0.200", 80);
                httpParams.setParameter(ConnRoutePNames.DEFAULT_PROXY, proxy);
            } else if (SmartHttp.MOBILE_CMWAP.equalsIgnoreCase(typeName)
                    || SmartHttp.MOBILE_UNIWAP.equalsIgnoreCase(typeName)
                    || SmartHttp.MOBILE_3GWAP.equalsIgnoreCase(typeName)) {
                final HttpHost proxy = new HttpHost("10.0.0.172", 80);
                httpParams.setParameter(ConnRoutePNames.DEFAULT_PROXY, proxy);
            }
        }
    }
    
    static final String TAG = SmartHttp.class.getSimpleName();
    public static final int SOCKET_BUFFER_SIZE = 8 * 1024;
    public static final int CONNECTION_TIMEOUT_MS = 20000;
    public static final int SOCKET_TIMEOUT_MS = 20000;
    public static final int MAX_TOTAL_CONNECTIONS = 20;
    public static final int MAX_RETRY_TIMES = 3;
    static final String WIFI = "WIFI";
    static final String MOBILE_CTWAP = "ctwap";
    static final String MOBILE_CMWAP = "cmwap";
    static final String MOBILE_3GWAP = "3gwap";
    static final String MOBILE_UNIWAP = "uniwap";
}
