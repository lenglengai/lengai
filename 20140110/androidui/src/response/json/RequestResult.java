package response.json;

public class RequestResult {

	public int getErrorCode() {
		return mErrorCode;
	}
    
	public String getMessage() {
		return mMessage;
	}
	
    public RequestResult(final int nErrorCode,
    		final String nMessage) {
        this.mErrorCode = nErrorCode;
        this.mMessage = nMessage;
    }
    
    final int mErrorCode;
    final String mMessage;
    
}
