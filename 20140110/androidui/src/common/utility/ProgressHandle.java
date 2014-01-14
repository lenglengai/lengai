package common.utility;

import common.utility.ErrorCode_;
import io.http.IJsonRequest;
import io.http.IJsonRespone;
import io.http.RequestResult;
import io.http.SmartHttp;
import android.os.AsyncTask;

public class ProgressHandle extends AsyncTask<Void, Integer, RequestResult> {

	@Override
	protected RequestResult doInBackground(Void... arg0) {
		IJsonRequest jsonRequest = (IJsonRequest)this;
		IJsonRespone jsonRespone = jsonRequest.getRespone();
		RequestResult requestResult = SmartHttp.runPost(jsonRequest, jsonRespone);
		publishProgress(1);
		if (requestResult.getErrorCode() == ErrorCode_.mSucess_) {
			jsonRespone.runRespone();
		}
		return requestResult;
	}

}
