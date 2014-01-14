package serialize.json;

import java.util.List;
import java.util.Stack;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import android.util.Log;

public class JsonReader  implements IJsonSerialize {

	@Override
	public Boolean serialize(Boolean nValue, String nName)
			throws JSONException {
		return mObject.getBoolean(nName);
	}

	@Override
	public byte serialize(byte nValue, String nName) 
			throws JSONException {
		return (byte)(mObject.getInt(nName));
	}

	@Override
	public void serialize_8(List<Byte> nValue, String nName)
			throws JSONException {
		JSONArray array_ = mObject.getJSONArray(nName);
		int length_ = array_.length();
		for (int i = 0; i < length_; i++) {
			Byte byte_ = new Byte((byte)array_.getInt(i));
			nValue.add(byte_);
		}
	}
	
	@Override
	public short serialize(short nValue, String nName) 
			throws JSONException {
		return (short)(mObject.getInt(nName));
	}

	@Override
	public void serialize_16(List<Short> nValue, String nName)
			throws JSONException {
		JSONArray array_ = mObject.getJSONArray(nName);
		int length_ = array_.length();
		for (int i = 0; i < length_; i++) {
			Short byte_ = new Short((short)array_.getInt(i));
			nValue.add(byte_);
		}
	}
	
	@Override
	public int serialize(int nValue, String nName)
			throws JSONException {
		return mObject.getInt(nName);
	}

	@Override
	public void serialize_32(List<Integer> nValue, String nName)
			throws JSONException {
		JSONArray array_ = mObject.getJSONArray(nName);
		int length_ = array_.length();
		for (int i = 0; i < length_; i++) {
			Integer int_ = Integer.valueOf(array_.getInt(i));
			nValue.add(int_);
		}
	}
	
	@Override
	public long serialize(long nValue, String nName) 
			throws JSONException {
		return mObject.getLong(nName);
	}

	@Override
	public void serialize_64(List<Long> nValue, String nName)
			throws JSONException {
		JSONArray array_ = mObject.getJSONArray(nName);
		int length_ = array_.length();
		for (int i = 0; i < length_; i++) {
			Long long_ = Long.valueOf(array_.getLong(i));
			nValue.add(long_);
		}
	}

	@Override
	public float serialize(float nValue, String nName)
			throws JSONException {
		return (float)(mObject.getDouble(nName));
	}

	@Override
	public void serialize_f(List<Float> nValue, String nName)
			throws JSONException {
		JSONArray array_ = mObject.getJSONArray(nName);
		int length_ = array_.length();
		for (int i = 0; i < length_; i++) {
			Float float_ = Float.valueOf((float)array_.getDouble(i));
			nValue.add(float_);
		}
	}
	
	@Override
	public double serialize(double nValue, String nName)
			throws JSONException {
		return mObject.getDouble(nName);
	}

	@Override
	public void serialize_d(List<Double> nValue, String nName)
			throws JSONException {
		JSONArray array_ = mObject.getJSONArray(nName);
		int length_ = array_.length();
		for (int i = 0; i < length_; i++) {
			Double double_ = Double.valueOf((double)array_.getDouble(i));
			nValue.add(double_);
		}
	}
	
	@Override
	public String serialize(String nValue, String nName)
			throws JSONException {
		return mObject.getString(nName);
	}

	@Override
	public void serialize_s(List<String> nValue, String nName)
			throws JSONException {
		JSONArray array_ = mObject.getJSONArray(nName);
		int length_ = array_.length();
		for (int i = 0; i < length_; i++) {
			nValue.add(array_.getString(i));
		}
	}

	@Override
	public <T extends IJsonStream> void serialize(T nValue, String nName)
			throws JSONException {
		mObjects.push(mObject);
		mObject = mObject.getJSONObject(nName);
		nValue.serialize(this);
	}

	@Override
	public <T extends IJsonStream> void serialize_t(List<T> nValue, String nName, Class<T> nClass)
			throws JSONException {
		mObjects.push(mObject);
		JSONArray array_ = mObject.getJSONArray(nName);
		int length_ = array_.length();
		try {
			for (int i = 0; i < length_; i++) {
				mObject = array_.getJSONObject(i);
				T value_ = nClass.newInstance();
				value_.serialize(this);
				nValue.add(value_);
			}
		} catch (InstantiationException e) {
			Log.e(JsonReader.TAG, e.toString());
		} catch (IllegalAccessException e) {
			Log.e(JsonReader.TAG, e.toString());
		}
		mObject = mObjects.pop();
	}
	
	public JsonReader(String nValue) throws JSONException {
		Log.v("jsonreader", nValue);
		mObjects = new Stack<JSONObject>();
		mObject = new JSONObject(nValue);
	}
	
	static final String TAG = JsonReader.class.getSimpleName();
	Stack<JSONObject> mObjects;
	JSONObject mObject;	
}
