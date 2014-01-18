package serialize.json;

import org.json.JSONException;

import io.http.SmartHttp;
import common.startup.AppContext;
import common.utility.ErrorCode_;
import common.utility.Setting;
import android.content.Context;
import android.os.AsyncTask;

public abstract class JsonTask extends AsyncTask<Void, Integer, RequestResult> implements IJsonHeadstream {

	@Override
	public <T extends IJsonSerialize> void headSerialize(T nT)
			throws JSONException {
		nT.serialize(mVersionId, "m_tVersion");
	}

	@Override
	public abstract String streamName();
	
	@Override
	protected RequestResult doInBackground(Void... arg0) {
		JsonResponseMgr jsonResponseMgr = new JsonResponseMgr();
		RequestResult requestResult = SmartHttp.runPost(this, jsonResponseMgr);
		if (mIsCancel) {
			return new RequestResult(ErrorCode_.mCancelled_, null);
		}
		publishProgress(1);
		if (requestResult.getErrorCode() == ErrorCode_.mSucess_) {
			jsonResponseMgr.setContext(mContext);
			jsonResponseMgr.runResponse();
		}
		return requestResult;
	}
	
	public void setCancel(boolean nCancel) {
		mIsCancel = nCancel;
	}
	
	protected void setContext(Context nContext) {
		mContext = nContext;
	}
	
	public JsonTask() {
        Setting setting = AppContext.getSetting();
        mVersionId = setting.getVersionId();
        mIsCancel = false;
		mContext = null;
	}

    boolean mIsCancel;
	Context mContext;
	int mVersionId;
}
