package serialize.json;

import org.json.JSONException;

import android.content.Context;

public class JsonResponse implements IJsonStream {

	@Override
	public <T extends IJsonSerialize> void serialize(T nT)
			throws JSONException {
		mId = nT.serialize(mId, "id");
		IJsonCreator jsonCreator = JsonCreatorMgr._getJsonCreator(mId);
		mJsonResponse = jsonCreator.createJsonResponse();
		mJsonResponse.serialize(nT);
	}
	
	public void runResponse(){
		mJsonResponse.runResponse();
	}
	
	public void setContext(Context nContext){
		mJsonResponse.setContext(nContext);
	}
	
	public JsonResponse() {
		mId = 0;
	}
	
	IJsonResponse mJsonResponse;
	long mId;
}
