package response.json;

import java.util.ArrayList;
import java.util.List;

import org.json.JSONException;

import serialize.json.IJsonHeadstream;
import serialize.json.IJsonSerialize;

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
	
	public List<Integer> runResponse(){
		List<Integer> result = new ArrayList<Integer>();
		for (JsonResponse i : mJsonResponses) {
			int errorCode = i.runResponse();
			result.add(errorCode);
		}
		return result;
	}

	public JsonResponseMgr() {
		mJsonResponses = new ArrayList<JsonResponse>();
	}

	List<JsonResponse> mJsonResponses;
	
}
