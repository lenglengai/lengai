package common.utility;

import android.content.Context;
import android.os.Looper;
import android.widget.Toast;

public class CommonHelper {

    public static void notify(final Context nContext, final CharSequence nText) {
    	Toast.makeText(nContext, nText, Toast.LENGTH_LONG).show();
    }
    
    public static void notifyThread(final Context nContext, final CharSequence nText) {
    	Looper.prepare();
    	Toast.makeText(nContext, nText, Toast.LENGTH_LONG).show();
    	Looper.loop();
    }
    
	public static String getJson(String nValue) {
		if (nValue != null && nValue.startsWith("\ufeff")) {
			int begin = nValue.indexOf("{");
			int end = nValue.lastIndexOf("}");
			nValue = nValue.substring(begin, (end + 1));
		}
		int begin = nValue.indexOf("\"");
		int end = nValue.lastIndexOf("\"");
		nValue = nValue.substring((begin + 1), end);

		StringBuffer stringBuffer = new StringBuffer();
		for (int i = 0; i < nValue.length(); ++i)
		{
			char c = nValue.charAt(i);
			if (c != '\\') {
				stringBuffer.append(c);
			}
		}
		return stringBuffer.toString();
	}
}
