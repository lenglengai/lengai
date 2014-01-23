package common.response;

import org.json.JSONException;

import response.json.IJsonResponse;
import serialize.json.IJsonSerialize;

import android.content.Context;

public class VersionResponse implements IJsonResponse {
	
	@Override
	public <T extends IJsonSerialize> void serialize(T nT)
			throws JSONException {
		
	}
	
	@Override
	public void setContext(Context nContext) {
		
	}

	@Override
	public void runResponse() {
		
	}

}
