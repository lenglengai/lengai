package serialize.sql;

public class SqlParameter {

    public String getName()
    {
        return mName;
    }

    public Object getValue()
    {
        return mValue;
    }

    public SqlParameter(String nName, Object nValue)
    {
        mName = nName;
        mValue = nValue;
    }

    String mName;
    Object mValue;
    
}
