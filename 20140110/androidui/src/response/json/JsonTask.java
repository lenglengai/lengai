package response.json;

import java.util.ArrayList;
import java.util.List;

import org.json.JSONException;

import serialize.json.IJsonHeadstream;
import serialize.json.IJsonSerialize;

import io.http.SmartHttp;
import common.startup.AppContext;
import common.utility.ErrorCode_;
import common.utility.Setting;
import android.content.Context;
import android.os.AsyncTask;

public abstract class JsonTask extends AsyncTask<Void, Integer, List<Integer> >
		implements IJsonHeadstream {

	@Override
	public <T extends IJsonSerialize> void headSerialize(T nT)
			throws JSONException {
		nT.serialize(mVersionId, "m_tVersion");
	}

	@Override
	public abstract String streamName();

	@Override
	protected List<Integer> doInBackground(Void... arg0) {
		List<Integer> result;
		JsonResponseMgr jsonResponseMgr = new JsonResponseMgr();
		int errorCode = SmartHttp.runPost(this, jsonResponseMgr);
		if (mIsCancel) {
			result = new ArrayList<Integer>();
			result.add(ErrorCode_.mCancelled_);
		}
		publishProgress(1);
		if (errorCode == ErrorCode_.mSucess_) {
			result = jsonResponseMgr.runResponse();
		} else {
			result = new ArrayList<Integer>();
			result.add(errorCode);
		}
		return result;
	}

	public void setCancel(boolean nCancel) {
		mIsCancel = nCancel;
	}

	protected void setContext(Context nContext) {
		mContext = nContext;
	}

	protected Context getContext() {
		return mContext;
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
