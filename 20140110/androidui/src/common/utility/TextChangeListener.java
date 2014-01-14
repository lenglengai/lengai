package common.utility;

import android.text.Editable;
import android.text.TextWatcher;

public abstract class TextChangeListener implements TextWatcher {
	
    public TextChangeListener() {
    }

    @Override
    public void afterTextChanged(final Editable s) {

    }

    @Override
    public void beforeTextChanged(final CharSequence s, final int start,
            final int count, final int after) {

    }

    @Override
    public abstract void onTextChanged(CharSequence s, int start, int before,
            int count);
    
}
