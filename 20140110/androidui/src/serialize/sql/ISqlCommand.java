package serialize.sql;

import java.util.List;

public interface ISqlCommand {

	Boolean serialize(Boolean nValue, String nName, int nSqlFieldId);
	Boolean serialize(Boolean nValue, String nName);

	byte serialize(byte nValue, String nName, int nSqlFieldId);
	byte serialize(byte nValue, String nName);
	void serialize_8(List<Byte> nValue, String nName);

	byte[] serialize(byte[] nValue, String nName, int nSqlFieldId);
	byte[] serialize(byte[] nValue, String nName);

	short serialize(short nValue, String nName, int nSqlFieldId);
	short serialize(short nValue, String nName);
	void serialize_16(List<Short> nValue, String nName);

	int serialize(int nValue, String nName, int nSqlFieldId);
	int serialize(int nValue, String nName);
	void serialize_32(List<Integer> nValue, String nName);

	long serialize(long nValue, String nName, int nSqlFieldId);
	long serialize(long nValue, String nName);
    void serialize_64(List<Long> nValue, String nName);

    float serialize(float nValue, String nName, int nSqlFieldId);
    float serialize(float nValue, String nName);
    void serialize_f(List<Float> nValue, String nName);
    
    double serialize(double nValue, String nName, int nSqlFieldId);
    double serialize(double nValue, String nName);
    void serialize_d(List<Double> nValue, String nName);
        
    String serialize(String nValue, String nName, int nSqlFieldId);
    String serialize(String nValue, String nName);
    void serialize_s(List<String> nValue, String nName);
    
    <T> T serialize(T nValue, String nName, int nSqlFieldId);
    <T> T serialize(T nValue, String nName);
    <T extends ISqlStream> void serialize_t(List<T> nValue, String nName, Class<T> nClass);
    
}
