package ui.account;

import org.json.JSONException;

import io.http.IJsonRespone;
import serialize.json.IJsonSerialize;

public class LoginRespone implements IJsonRespone {

	@Override
	public <T extends IJsonSerialize> void headSerialize(T nT)
			throws JSONException {
		
	}

	@Override
	public String streamName() {
		return "loginRespone";
	}

	@Override
	public void runRespone() {
		
	}
	
    int m_tErrorCode;
    int m_tAccountId;
    String m_tNickName;
    int m_tServerId;
    long m_tTicks;
    long m_tDeviceId;
    int m_tDeviceType;

}
