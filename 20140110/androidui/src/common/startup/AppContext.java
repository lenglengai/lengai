package common.startup;

import serialize.json.JsonCreatorMgr;
import common.utility.Setting;

import android.app.Application;
import android.content.SharedPreferences;
import android.preference.PreferenceManager;

public class AppContext extends Application {

	@Override
	public void onCreate() {
		
		super.onCreate();
		
		AppContext.mPreferences = PreferenceManager.
				getDefaultSharedPreferences(this);
		AppContext.mInstance = this;
		mSetting = new Setting();
		mSetting.runInit(this);
		JsonCreatorMgr.runInit();
	}
	
	public static Setting getSetting() {
		return mSetting;
	}
	
    public static AppContext getAppContext() {
        return AppContext.mInstance;
    }
	
    static SharedPreferences mPreferences;
    static AppContext mInstance;
    static Setting mSetting;
}
