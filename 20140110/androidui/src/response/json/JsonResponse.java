package response.json;

import org.json.JSONException;

import serialize.json.IJsonSerialize;
import serialize.json.IJsonStream;

public class JsonResponse implements IJsonStream {

	@Override
	public <T extends IJsonSerialize> void serialize(T nT)
			throws JSONException {
		mId = nT.serialize(mId, "id");
		IJsonCreator jsonCreator = JsonCreatorMgr._getJsonCreator(mId);
		mJsonResponse = jsonCreator.createJsonResponse();
		mJsonResponse.serialize(nT);
	}
	
	public int runResponse(){
		return mJsonResponse.runResponse();
	}
	
	public JsonResponse() {
		mId = 0;
	}
	
	IJsonResponse mJsonResponse;
	long mId;
}
