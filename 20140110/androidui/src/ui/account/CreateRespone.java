package ui.account;

import org.json.JSONException;

import io.http.IJsonRespone;
import serialize.json.IJsonSerialize;

public class CreateRespone implements IJsonRespone {

	@Override
	public <T extends IJsonSerialize> void headSerialize(T nT)
			throws JSONException {
		nT.serialize(mAccountError, "accountError");
	}

	@Override
	public String streamName() {
		return "createRespone";
	}

	@Override
	public void runRespone() {
		
	}
	
	public CreateRespone() {
		
	}
	int mAccountError;
}
