package common.utility;

import common.startup.R;

public class ErrorCode_ {
	
	public static int getString(int nErrorCode) {
		int result = mSucess_;
		if (mHttpIO_ == nErrorCode) {
			result = R.string.connection_error;
		} else if (mJson_ == nErrorCode) {
			result = R.string.system_error;
		} else if (mHttpParse_ == nErrorCode) {
			result = R.string.system_error;
		} else if (mClientProtocol_ == nErrorCode) {
			result = R.string.system_error;
		} else if (mEncoding_ == nErrorCode) {
			result = R.string.system_error;
		} else if (mCancelled_ == nErrorCode) {
			result = R.string.system_error;
		} else if (mVersion == nErrorCode) {
			result = R.string.client_version;
		} else if (mCreateSucess == nErrorCode) {
			result = R.string.create_account_sucess;
		} else if (mCreateName == nErrorCode) {
			result = R.string.create_username_exit;
		} else {
		}
		return result;
	}

	public static final int mHttpOk_ = 200;
	public static final int mSucess_ = 0;
	public static final int mHttpIO_ = -1;
	public static final int mJson_ = -2;
	public static final int mHttpParse_ = -3;
	public static final int mClientProtocol_ = -4;
	public static final int mEncoding_ = -5;
	public static final int mCancelled_ = -6;
	public static final int mVersion = -7;
	public static final int mCreateSucess = -8;
	public static final int mCreateName = -9;
	
	
}
