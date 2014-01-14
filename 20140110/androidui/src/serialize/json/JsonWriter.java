package serialize.json;

import java.util.List;
import java.util.Stack;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import android.util.Log;

public class JsonWriter implements IJsonSerialize {

	@Override
	public Boolean serialize(Boolean nValue, String nName)
			throws JSONException {
		mObject.put(nName, nValue);
		return nValue;
	}

	@Override
	public byte serialize(byte nValue, String nName)
			throws JSONException {
		mObject.put(nName, nValue);
		return nValue;
	}
	
	@Override
	public void serialize_8(List<Byte> nValue, String nName)
			throws JSONException {
		mObjects.push(mObject);
		JSONArray array_ = new JSONArray();
		for (Byte t : nValue) {
			array_.put(t);
		}
		mObject = mObjects.pop();
	}

	@Override
	public short serialize(short nValue, String nName)
			throws JSONException {
		mObject.put(nName, nValue);
		return nValue;
	}

	@Override
	public void serialize_16(List<Short> nValue, String nName)
			throws JSONException {
		mObjects.push(mObject);
		JSONArray array_ = new JSONArray();
		for (Short t : nValue) {
			array_.put(t);
		}
		mObject = mObjects.pop();
	}
	
	@Override
	public int serialize(int nValue, String nName)
			throws JSONException {
		mObject.put(nName, nValue);
		return nValue;
	}

	@Override
	public void serialize_32(List<Integer> nValue, String nName)
			throws JSONException {
		mObjects.push(mObject);
		JSONArray array_ = new JSONArray();
		for (Integer t : nValue) {
			array_.put(t);
		}
		mObject = mObjects.pop();
	}

	@Override
	public long serialize(long nValue, String nName)
			throws JSONException {
		mObject.put(nName, nValue);
		return nValue;
	}

	@Override
	public void serialize_64(List<Long> nValue, String nName)
			throws JSONException {
		mObjects.push(mObject);
		JSONArray array_ = new JSONArray();
		for (Long t : nValue) {
			array_.put(t);
		}
		mObject = mObjects.pop();
	}
	
	@Override
	public float serialize(float nValue, String nName)
			throws JSONException {
		mObject.put(nName, nValue);
		return nValue;
	}

	@Override
	public void serialize_f(List<Float> nValue, String nName)
			throws JSONException {
		mObjects.push(mObject);
		JSONArray array_ = new JSONArray();
		for (Float t : nValue) {
			array_.put(t);
		}
		mObject = mObjects.pop();
	}

	@Override
	public double serialize(double nValue, String nName)
			throws JSONException {
		mObject.put(nName, nValue);
		return nValue;
	}

	@Override
	public void serialize_d(List<Double> nValue, String nName)
			throws JSONException {
		mObjects.push(mObject);
		JSONArray array_ = new JSONArray();
		for (Double t : nValue) {
			array_.put(t);
		}
		mObject = mObjects.pop();
	}

	@Override
	public String serialize(String nValue, String nName)
			throws JSONException {
		mObject.put(nName, nValue);
		return nValue;
	}

	@Override
	public void serialize_s(List<String> nValue, String nName)
			throws JSONException {
		mObjects.push(mObject);
		JSONArray array_ = new JSONArray();
		for (String t : nValue) {
			array_.put(t);
		}
		mObject = mObjects.pop();
	}

	@Override
	public <T extends IJsonStream> void serialize(T nValue, String nName)
			throws JSONException {
		mObjects.push(mObject);
		mObject = new JSONObject();
		nValue.serialize(this);
		JSONObject object_ = mObjects.pop();
		object_.put(nName, mObject);
		mObject = object_;
	}

	@Override
	public <T extends IJsonStream> void serialize_t(List<T> nValue, String nName, Class<T> nClass)
			throws JSONException {
		mObjects.push(mObject);
		JSONArray array_;
		array_ = new JSONArray();
		for (T t : nValue) {
			mObject = new JSONObject();
			t.serialize(this);
			array_.put(t);
		}
		mObject = mObjects.pop();
	}
	
	public String getValue() {
		String json = mObject.toString();
		Log.v("jsonWriter", json);
		return mObject.toString();
	}
	
	public JsonWriter() {
		mObjects = new Stack<JSONObject>();
		mObject = new JSONObject();
	}
	
	Stack<JSONObject> mObjects;
	JSONObject mObject;

}
