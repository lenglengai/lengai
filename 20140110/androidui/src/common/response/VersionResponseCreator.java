package common.response;

import response.json.IJsonResponse;

public class VersionResponseCreator extends CommonResponseCreator {

	@Override
	public IJsonResponse createJsonResponse() {
		return new VersionResponse();
	}

	@Override
	public int getId() {
		return COMMONCONSTS.VERSION;
	}

}
