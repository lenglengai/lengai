package serialize.json;

import java.util.List;
import org.json.JSONException;

public interface IJsonSerialize {

	Boolean serialize(Boolean nValue, String nName) 
			throws JSONException;
	
	byte serialize(byte nValue, String nName)
			throws JSONException;
	void serialize_8(List<Byte> nValue, String nName)
			throws JSONException;
	
	short serialize(short nValue, String nName)
			throws JSONException;
	void serialize_16(List<Short> nValue, String nName)
			throws JSONException;
	
	int serialize(int nValue, String nName)
			throws JSONException;
	void serialize_32(List<Integer> nValue, String nName)
			throws JSONException;
	
	long serialize(long nValue, String nName)
			throws JSONException;
	void serialize_64(List<Long> nValue, String nName)
			throws JSONException;
	
	float serialize(float nValue, String nName)
			throws JSONException;
	void serialize_f(List<Float> nValue, String nName)
			throws JSONException;
	
	double serialize(double nValue, String nName)
			throws JSONException;
	void serialize_d(List<Double> nValue, String nName)
			throws JSONException;
	
	String serialize(String nValue, String nName)
			throws JSONException;
	void serialize_s(List<String> nValue, String nName)
			throws JSONException;
	
	<T extends IJsonStream> void serialize(T nValue, String nName) 
			throws JSONException;
	<T extends IJsonStream> void serialize_t(List<T> nValue, String nName, Class<T> nClass)
			throws JSONException;
	
}
