package serialize.json;

import org.json.JSONException;

public interface IJsonHeadstream {

	<T extends IJsonSerialize> void headSerialize(T nT)
			throws JSONException;
	
	String streamName();
	
}
