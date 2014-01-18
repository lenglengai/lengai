package serialize.json;

import java.util.ArrayList;
import java.util.List;

import org.json.JSONException;

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
	
	public void runResponse(){
		for (JsonResponse i : mJsonResponses) {
			i.runResponse();
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
