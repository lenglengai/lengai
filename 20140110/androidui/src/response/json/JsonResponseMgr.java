package response.json;

import java.util.ArrayList;
import java.util.List;

import org.json.JSONException;

import serialize.json.IJsonHeadstream;
import serialize.json.IJsonSerialize;

import common.utility.ErrorCode_;

import android.content.Context;

public class JsonResponseMgr implements IJsonHeadstream {
	
	@Override
	public <T extends IJsonSerialize> void headSerialize(T nT)
			throws JSONException {
		nT.serialize_t(mJsonResponses, "news", JsonResponse.class);
	}

	@Override
	public String streamName() {
		return "jsonResponseMgr";
	}
	
	public int runResponse(){
		int errorCode = ErrorCode_.mSucess_;
		for (JsonResponse i : mJsonResponses) {
			errorCode = i.runResponse();
		}
	}

	public void setContext(Context nContext){
		for (JsonResponse i : mJsonResponses) {
			i.setContext(nContext);
			i.runResponse();
		}
	}
	
	public JsonResponseMgr() {
		mJsonResponses = new ArrayList<JsonResponse>();
	}

	List<JsonResponse> mJsonResponses;
	
}
