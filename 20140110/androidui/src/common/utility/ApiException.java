package common.utility;

public class ApiException extends Exception {
	
	private static final long serialVersionUID = 1L;
	
	public int getErrorCode() {
		return mErrorCode;
	}
    
	public String getMessage() {
		return mMessage;
	}
	
    public ApiException(final int nErrorCode,
    		final String nMessage) {
        super(nMessage);
        this.mErrorCode = nErrorCode;
        this.mMessage = nMessage;
    }
    
    final int mErrorCode;
    final String mMessage;
}
