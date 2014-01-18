package ui.account;


import org.json.JSONException;


import android.app.ProgressDialog;
import android.content.Context;
import android.content.DialogInterface;

import common.startup.R;
import common.utility.CommonHelper;
import common.utility.ErrorCode_;

import serialize.json.IJsonSerialize;
import serialize.json.JsonTask;
import serialize.json.RequestResult;


public class CreateRequest extends JsonTask {

	@Override
    protected void onPostExecute(final RequestResult result) {
        if (null != mProgressDialog) {
            mProgressDialog.dismiss();
        }
        switch (result.getErrorCode()) {
        case ErrorCode_.mHttpIO_: {
        	Context context = this.getContext();
        	String errorMessage = context.getString(R.string.connection_error);
            CommonHelper.notify(context, errorMessage);
            }
        	break;
        case ErrorCode_.mHttpOk_:
            break;
        default: {
        	Context context = this.getContext();
        	String errorMessage = context.getString(R.string.system_error);
        	CommonHelper.notify(context, errorMessage);
        	}
        	break;
        }
    }
    
    @Override
    protected void onPreExecute() {
    	Context context = this.getContext();
        mProgressDialog = new ProgressDialog(context);
        String message_ = context.getString(R.string.user_creating);
		mProgressDialog.setMessage(message_);
        mProgressDialog.setIndeterminate(true);
        mProgressDialog.setOnCancelListener(new DialogInterface.OnCancelListener() {
                    @Override
                    public void onCancel(final DialogInterface dialog) {
                    	CreateRequest.this.setCancel(true);
                        cancel(true);
                    }
                });
        mProgressDialog.show();
    }
    
    @Override
    protected void onProgressUpdate(final Integer... values) {
        if (values.length > 0) {
            final int value = values[0];
            if (value == 1) {
            	Context context = this.getContext();
                String message_ = context.getString(R.string.user_creating_val);
                mProgressDialog.setMessage(message_);
            }
        }
    }
    
	@Override
	public <T extends IJsonSerialize> void headSerialize(T nT)
			throws JSONException {
		super.headSerialize(nT);
		nT.serialize(mName, "m_tName");
		nT.serialize(mNick, "m_tNick");
		nT.serialize(mPassward, "m_tPassward");
		nT.serialize(mGetPassward, "m_tGetPassward");
	}
	
	@Override
	public String streamName() {
		return "api/Account/_createAccount";
	}

	public CreateRequest(Context nContext, String nName,
			String nNick, String nPassward, String nGetPassward) {
		this.setContext(nContext);
		mProgressDialog = null;
		mGetPassward = nGetPassward;
		mPassward = nPassward;
		mName = nName;
		mNick = nNick;
	}
	
	ProgressDialog mProgressDialog;
	String mGetPassward;
    String mPassward;
    String mName;
    String mNick;
	
}
