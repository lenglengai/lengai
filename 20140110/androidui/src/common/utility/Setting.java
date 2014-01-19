package common.utility;

import android.content.Context;
import android.content.pm.PackageInfo;
import android.content.pm.PackageManager;
import android.content.pm.PackageManager.NameNotFoundException;

public class Setting {

	public void runInit(Context nContext) {
        
        try {
        	final PackageManager packageManager = nContext.getPackageManager();
        	String packageName = nContext.getPackageName();
        	PackageInfo packageInfo = packageManager.getPackageInfo(packageName, 0);
        	mVersionCode = packageInfo.versionCode;
        	mVersionName = packageInfo.versionName;
        } catch (final NameNotFoundException e) {
        }
        
	}
	public int getVersionId() {
		return mVersionId;
	}
	
	public int getVersionCode() {
		return mVersionCode;
	}
	
	public String getVersionName() {
		return mVersionName;
	}
	
	public String getHost() {
		return mHost;
	}
	
	public int getDeviceId() {
		return -888114033;
	}
	
	public Setting() {
		mHost = "http://192.168.10.38/";
		mVersionName = "1.0";
        mVersionCode = 20140101;
        mVersionId = 1;
	}
	
    public String mHost;
    String mVersionName;
    int mVersionCode;
    int mVersionId;
    
}
