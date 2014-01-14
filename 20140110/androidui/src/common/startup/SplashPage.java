package common.startup;

import ui.account.CreateRequest;
import ui.account.LoginRequest;

import common.utility.CommonHelper;
import common.utility.Setting;
import common.utility.TextChangeListener;
import android.os.Bundle;
import android.app.Activity;
import android.text.TextUtils;
import android.view.Menu;
import android.view.View;
import android.view.ViewStub;
import android.widget.Button;
import android.widget.EditText;

public class SplashPage extends Activity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.splash_page);
        this.initLayout();
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        getMenuInflater().inflate(R.menu.splash_page, menu);
        return true;
    }
    
    void initLayout() {
    	mLoginViewStub = (ViewStub)findViewById(R.id.spp_login_vs);
		mLoginBt = (Button)findViewById(R.id.spp_login_bt);
		mLoginBt.setOnClickListener(new View.OnClickListener() {
			@Override
			public void onClick(View v) {
				hideLoginBt();
				hideCreatePage();
				hideGetPage();
				showLoginPage();
			}
		});
		mCreateViewStub = (ViewStub)findViewById(R.id.spp_create_vs);
		mRegisterBt = (Button)findViewById(R.id.spp_register_bt);
		mRegisterBt.setOnClickListener(new View.OnClickListener() {
			@Override
			public void onClick(View v) {
				hideLoginBt();
				hideLoginPage();
				hideGetPage();
				showCreatePage();
			}
		});
		mGetViewStub = (ViewStub)findViewById(R.id.spp_getpassward_vs);
		mGetPasswardBt = (Button)findViewById(R.id.spp_getpassward_bt);
		mGetPasswardBt.setOnClickListener(new View.OnClickListener() {
			@Override
			public void onClick(View v) {
				hideLoginBt();
				hideLoginPage();
				hideCreatePage();
				showGetPage();
			}
		});
    }
        
    void hideLoginBt() {
    	mLoginBt.setVisibility(View.GONE);
    }
    
    void showLoginBt() {
    	mLoginBt.setVisibility(View.VISIBLE);
    }
    
    Button mLoginBt;
    Button mRegisterBt;
    Button mGetPasswardBt;
    
    void showLoginPage() {
		if(null == mLoginView) {
			mLoginView = mLoginViewStub.inflate();
			mLUserName = (EditText)mLoginView.findViewById(R.id.lp_username_et);
			mLUserName.addTextChangedListener(new TextChangeListener() {
				@Override
				public void onTextChanged(CharSequence s, int start, 
						int before, int count) {
					mLUserNameS = s.toString();
				}
			});
			mLPassward = (EditText)mLoginView.findViewById(R.id.lp_passward_et);
			mLPassward.addTextChangedListener(new TextChangeListener() {
				@Override
				public void onTextChanged(CharSequence s, int start, 
						int before, int count) {
					mLPasswardS = s.toString();
				}
			});
			mLLoginBt = (Button)mLoginView.findViewById(R.id.lp_login_bt);
			mLLoginBt.setOnClickListener(new View.OnClickListener() {
				@Override
				public void onClick(View v) {
					runLogin();
				}
			});
			mLReturnbt = (Button)mLoginView.findViewById(R.id.lp_return_bt);
			mLReturnbt.setOnClickListener(new View.OnClickListener() {
				@Override
				public void onClick(View v) {
					hideLoginPage();
					showLoginBt();
				}
			});
		}
		mLoginViewStub.setVisibility(View.VISIBLE);
    }
    
    void hideLoginPage() {
    	mLoginViewStub.setVisibility(View.GONE);
	}
    
    void runLogin() {
        if (TextUtils.isEmpty(mLUserNameS)) {
        	String enterUserName = this.getString(R.string.enter_username);
        	CommonHelper.notify(this, enterUserName);
        	return;
        }
        if (TextUtils.isEmpty(mLPasswardS)) {
        	String enterPassward = this.getString(R.string.enter_passward);
        	CommonHelper.notify(this, enterPassward);
        	return;
        }
        Setting setting = AppContext.getSetting();
        int deviceId = setting.getDeviceId();
        LoginRequest loginRequest = new LoginRequest(mLUserNameS, mLPasswardS, deviceId);
        loginRequest.execute();
    }
    
    ViewStub mLoginViewStub;
    View mLoginView;
    EditText mLUserName;
    String mLUserNameS;
    EditText mLPassward;
    String mLPasswardS;
    Button mLLoginBt;
    Button mLReturnbt;
    
    void showCreatePage() {
		if(null == mCreateView) {
			mCreateView = ((ViewStub)mCreateViewStub).inflate();
			mCUserName = (EditText)mCreateView.findViewById(R.id.cp_username_et);
			mCUserName.addTextChangedListener(new TextChangeListener() {
				@Override
				public void onTextChanged(CharSequence s, int start, 
						int before, int count) {
					mCUserNameS = s.toString();
				}
			});
			mCNickName = (EditText)mCreateView.findViewById(R.id.cp_nickname_et);
			mCNickName.addTextChangedListener(new TextChangeListener() {
				@Override
				public void onTextChanged(CharSequence s, int start, 
						int before, int count) {
					mCNickNameS = s.toString();
				}
			});
			mCPassward = (EditText)mCreateView.findViewById(R.id.cp_passward_et);
			mCPassward.addTextChangedListener(new TextChangeListener() {
				@Override
				public void onTextChanged(CharSequence s, int start, 
						int before, int count) {
					mCPasswardS = s.toString();
				}
			});
			mCGetPassward = (EditText)mCreateView.findViewById(R.id.cp_getpassward_et);
			mCGetPassward.addTextChangedListener(new TextChangeListener() {
				@Override
				public void onTextChanged(CharSequence s, int start, 
						int before, int count) {
					mCGetPasswardS = s.toString();
				}
			});
			mCreateBt = (Button)mCreateView.findViewById(R.id.cp_create_bt);
			mCreateBt.setOnClickListener(new View.OnClickListener() {
				@Override
				public void onClick(View v) {
					runCreate();
				}
			});
			mCReturnbt = (Button)mCreateView.findViewById(R.id.cp_return_bt);
			mCReturnbt.setOnClickListener(new View.OnClickListener() {
				@Override
				public void onClick(View v) {
					hideCreatePage();
					showLoginBt();
				}
			});
		}
		mCreateViewStub.setVisibility(View.VISIBLE);
    }
    
    void hideCreatePage() {
    	mCreateViewStub.setVisibility(View.GONE);
    }
    
    void runCreate() {
        if (TextUtils.isEmpty(mCUserNameS)) {
        	String enterUserName = this.getString(R.string.enter_username);
        	CommonHelper.notify(this, enterUserName);
        	return;
        }
        if (TextUtils.isEmpty(mCNickNameS)) {
        	String enterNickName = this.getString(R.string.enter_nickname);
        	CommonHelper.notify(this, enterNickName);
        	return;
        }
        if (TextUtils.isEmpty(mCPasswardS)) {
        	String enterPassward = this.getString(R.string.enter_passward);
        	CommonHelper.notify(this, enterPassward);
        	return;
        }
        if (TextUtils.isEmpty(mCGetPasswardS)) {
        	String getPassward = this.getString(R.string.enter_getpassward);
        	CommonHelper.notify(this, getPassward);
        	return;
        }
        CreateRequest createRequest = new CreateRequest
        		(mCUserNameS, mCNickNameS, mCPasswardS, mCGetPasswardS);
        createRequest.execute();
    }
    
    ViewStub mCreateViewStub;
    View mCreateView;
    EditText mCUserName;
    String mCUserNameS;
    EditText mCNickName;
    String mCNickNameS;
    EditText mCPassward;
    String mCPasswardS;
    EditText mCGetPassward;
    String mCGetPasswardS;
    Button mCreateBt;
    Button mCReturnbt;
    
    void showGetPage() {
		if(null == mGetView) {
			mGetView = mGetViewStub.inflate();
			mGUserName = (EditText)mGetView.findViewById(R.id.gp_username_et);
			mGGetPassward = (EditText)mGetView.findViewById(R.id.gp_getpassward_et);
			mGNewPassward = (EditText)mGetView.findViewById(R.id.gp_newpassward_et);
			mGetBt = (Button)mGetView.findViewById(R.id.gp_get_bt);
			mGetBt.setOnClickListener(new View.OnClickListener() {
				@Override
				public void onClick(View v) {
					runGetPassward();
				}
			});
			mGReturnbt = (Button)mGetView.findViewById(R.id.gp_return_bt);
			mGReturnbt.setOnClickListener(new View.OnClickListener() {
				@Override
				public void onClick(View v) {
					hideGetPage();
					showLoginBt();
				}
			});
		}
		mGetViewStub.setVisibility(View.VISIBLE);
    }
    
    void hideGetPage() {
    	mGetViewStub.setVisibility(View.GONE);
    }
    
    void runGetPassward() {
    	
    }
    
    ViewStub mGetViewStub;
    View mGetView;
    EditText mGUserName;
    EditText mGGetPassward;
    EditText mGNewPassward;
    Button mGetBt;
    Button mGReturnbt;
}
