package ui.account;

import serialize.json.IJsonResponse;


public class CreateRequestCreator extends AccountRequestCreator {

	@Override
	public IJsonResponse createJsonResponse() {
		return new CreateResponse();
	}

	@Override
	public int getId() {
		return ACCOUNTCONSTS.CREATE;
	}

}
