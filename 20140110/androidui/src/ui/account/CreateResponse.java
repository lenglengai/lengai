package ui.account;

import org.json.JSONException;

import common.startup.R;
import common.utility.CommonHelper;

import android.content.Context;
import serialize.json.IJsonResponse;
import serialize.json.IJsonSerialize;

public class CreateResponse implements IJsonResponse {

	@Override
	public <T extends IJsonSerialize> void serialize(T nT)
			throws JSONException {
		mError = nT.serialize(mError, "error");
	}

	@Override
	public void setContext(Context nContext) {
		mContext = nContext;
	}

	@Override
	public void runResponse() {
		if (ACCOUNTCONSTS.CREATESUCESS == mError) {
			String text = mContext.getString(R.string.create_account_sucess);
			CommonHelper.notify(mContext, text);
		} else if (ACCOUNTCONSTS.CREATENAME == mError) {
			String text = mContext.getString(R.string.create_username_exit);
			CommonHelper.notify(mContext, text);
		} else {
		}  
	}
	
	public CreateResponse() {
		mContext = null;
	}
	
	Context mContext;
	int mError;
}
