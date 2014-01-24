package common.response;

import org.json.JSONException;

import common.utility.ErrorCode_;

import response.json.IJsonResponse;
import serialize.json.IJsonSerialize;


public class VersionResponse implements IJsonResponse {
	
	@Override
	public <T extends IJsonSerialize> void serialize(T nT)
			throws JSONException {
		
	}
	
	@Override
	public int runResponse() {
		return ErrorCode_.mVersion;
	}

}
