package ui.account;

import org.json.JSONException;

import common.utility.ProgressHandle;
import io.http.IJsonRequest;
import io.http.IJsonRespone;
import io.http.RequestResult;
import serialize.json.IJsonSerialize;

public class LoginRequest extends ProgressHandle implements IJsonRequest {

    @Override
    protected void onPostExecute(final RequestResult result) {
    }
    
    @Override
    protected void onPreExecute() {
    }
    
    @Override
    protected void onProgressUpdate(final Integer... values) {
    }

	@Override
	public <T extends IJsonSerialize> void headSerialize(T nT)
			throws JSONException {
		nT.serialize(mUserName, "m_tName");
		nT.serialize(mPassward, "m_tPassward");
		nT.serialize(mDevice, "m_tDeviceType");
	}

	@Override
	public String streamName() {
		return "api/Account/_loginAccount";
	}

	@Override
	public IJsonRespone getRespone() {
		return new LoginRespone();
	}
    
	public LoginRequest(String nUserName, String nPassward, int nDevice) {
		mUserName = nUserName;
		mPassward = nPassward;
		mDevice = nDevice;
	}
	
	String mUserName;
	String mPassward;
	int mDevice;
	
}

