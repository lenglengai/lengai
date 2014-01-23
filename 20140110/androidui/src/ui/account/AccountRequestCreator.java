package ui.account;

import response.json.IJsonCreator;
import response.json.IJsonResponse;

public abstract class AccountRequestCreator implements IJsonCreator {

	public abstract IJsonResponse createJsonResponse();

	@Override
	public String getContext() {
		return ACCOUNTCONSTS.CONTEXT;
	}

	public abstract int getId();

}
