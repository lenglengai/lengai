package ui.account;

import org.json.JSONException;

import common.utility.ErrorCode_;

import response.json.IJsonResponse;
import serialize.json.IJsonSerialize;

public class CreateResponse implements IJsonResponse {

	@Override
	public <T extends IJsonSerialize> void serialize(T nT)
			throws JSONException {
		mError = nT.serialize(mError, "error");
	}

	@Override
	public int runResponse() {
		int result = ErrorCode_.mSucess_;
		if (ACCOUNTCONSTS.CREATESUCESS == mError) {
			result = ErrorCode_.mCreateSucess;
		} else if (ACCOUNTCONSTS.CREATENAME == mError) {
			result = ErrorCode_.mCreateName;
		} else {
		}
		return result;
	}
	
	public CreateResponse() {
		mError = ErrorCode_.mSucess_;
	}
	
	int mError;
	
}
