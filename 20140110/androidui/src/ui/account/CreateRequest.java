package ui.account;

import org.json.JSONException;

import common.startup.AppContext;
import common.utility.ProgressHandle;
import common.utility.Setting;
import io.http.IJsonRequest;
import io.http.IJsonRespone;
import io.http.RequestResult;
import serialize.json.IJsonSerialize;

public class CreateRequest extends ProgressHandle implements IJsonRequest{

    @Override
    protected void onPostExecute(final RequestResult result) {
    }
    
    @Override
    protected void onPreExecute() {
    }
    
    @Override
    protected void onProgressUpdate(final Integer... values) {
    }
    
	@Override
	public <T extends IJsonSerialize> void headSerialize(T nT)
			throws JSONException {
		nT.serialize(mVersionId, "m_tVersion");
		nT.serialize(mName, "m_tName");
		nT.serialize(mNick, "m_tNick");
		nT.serialize(mPassward, "m_tPassward");
		nT.serialize(mGetPassward, "m_tGetPassward");
	}

	@Override
	public String streamName() {
		return "api/Account/_createAccount";
	}

	@Override
	public IJsonRespone getRespone() {
		return new CreateRespone();
	}

	public CreateRequest(String nName, String nNick,
			String nPassward, String nGetPassward) {
        Setting setting = AppContext.getSetting();
        mVersionId = setting.getVersionId();
		mGetPassward = nGetPassward;
		mPassward = nPassward;
		mName = nName;
		mNick = nNick;
	}
	
	String mGetPassward;
    String mPassward;
    String mName;
    String mNick;
    int mVersionId;
    
}
