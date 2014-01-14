package serialize.json;

import org.json.JSONException;

public interface IJsonStream {

	<T extends IJsonSerialize> void serialize(T nT)
			throws JSONException;
	
}
