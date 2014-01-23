package common.response;

import response.json.IJsonCreator;
import response.json.IJsonResponse;

public abstract class CommonResponseCreator implements IJsonCreator {

	public abstract IJsonResponse createJsonResponse();

	@Override
	public String getContext() {
		return COMMONCONSTS.CONTEXT;
	}

	public abstract int getId();

}
