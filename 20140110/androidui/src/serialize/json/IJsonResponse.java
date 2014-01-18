package serialize.json;

import android.content.Context;

public interface IJsonResponse extends IJsonStream {
	
	void setContext(Context nContext);
	
	void runResponse();
	
}
