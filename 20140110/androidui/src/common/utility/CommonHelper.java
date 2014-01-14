package common.utility;

import android.content.Context;
import android.widget.Toast;

public class CommonHelper {

    public static void notify(final Context nContext, final CharSequence nText) {
    	Toast.makeText(nContext, nText, Toast.LENGTH_LONG).show();
    }
}
