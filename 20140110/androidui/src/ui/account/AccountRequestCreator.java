package ui.account;

import serialize.json.IJsonCreator;
import serialize.json.IJsonResponse;

public abstract class AccountRequestCreator implements IJsonCreator {

	public abstract IJsonResponse createJsonResponse();

	@Override
	public String getContext() {
		return ACCOUNTCONSTS.CONTEXT;
	}

	public abstract int getId();

}
