package serialize.sql;

import java.util.ArrayList;
import java.util.List;

public class SqlCommand implements ISqlCommand {

	@Override
	public Boolean serialize(Boolean nValue, String nName, int nSqlFieldId) {
        if (SqlDeal_.mCreate_ == mSqlDeal)
        {
            this.runCreate("TINYINT(1)", nName, nSqlFieldId);
        }
        else if ((SqlDeal_.mPrimary_ == mSqlDeal) && ((nSqlFieldId & SqlFieldId_.mPrimary_) > 0))
        {
            this.runPrimary(nName);
        }
        else if (SqlDeal_.mSelect_ == mSqlDeal)
        {
            this.runSelect(nName);
        }
        else if (SqlDeal_.mWhere_ == mSqlDeal)
        {
            this.runWhere(nValue, nName);
        }
        else if (SqlDeal_.mInsert_ == mSqlDeal)
        {
            this.runInsert(nValue);
        }
        else if (SqlDeal_.mInsertUpdate_ == mSqlDeal)
        {
            this.runInsertUpdate(nName);
        }
        else if (SqlDeal_.mInsertUpdateE_ == mSqlDeal)
        {
            this.runInsertUpdateE(nName, nValue);
        }
        else if (SqlDeal_.mInsertUpdateEx_ == mSqlDeal)
        {
            this.runInsertUpdateEx(nName);
        }
        else if (SqlDeal_.mUpdate_ == mSqlDeal)
        {
            this.runUpdate(nValue, nName);
        }
        else if (SqlDeal_.mUpdateSelect_ == mSqlDeal)
        {
            this.updateSelect(nName);
        }
        else if (SqlDeal_.mUpdateWhen_ == mSqlDeal)
        {
            this.updateWhen(nValue);
        }
        else if (SqlDeal_.mUpdateThen_ == mSqlDeal)
        {
            this.updateThen(nValue, nName);
        }
        else
        {
        }
		return nValue;
	}

	@Override
	public Boolean serialize(Boolean nValue, String nName) {
		return this.serialize(nValue, nName, SqlFieldId_.mNone_);
	}

	@Override
	public byte serialize(byte nValue, String nName, int nSqlFieldId) {
        if (SqlDeal_.mCreate_ == mSqlDeal)
        {
            this.runCreate("INT(10)", nName, nSqlFieldId);
        }
        else if ((SqlDeal_.mPrimary_ == mSqlDeal) && ((nSqlFieldId & SqlFieldId_.mPrimary_) > 0))
        {
            this.runPrimary(nName);
        }
        else if (SqlDeal_.mSelect_ == mSqlDeal)
        {
            this.runSelect(nName);
        }
        else if (SqlDeal_.mWhere_ == mSqlDeal)
        {
            this.runWhere(nValue, nName);
        }
        else if (SqlDeal_.mInsert_ == mSqlDeal)
        {
            this.runInsert(nValue);
        }
        else if (SqlDeal_.mInsertUpdate_ == mSqlDeal)
        {
            this.runInsertUpdate(nName);
        }
        else if (SqlDeal_.mInsertUpdateE_ == mSqlDeal)
        {
            this.runInsertUpdateE(nName, nValue);
        }
        else if (SqlDeal_.mInsertUpdateEx_ == mSqlDeal)
        {
            this.runInsertUpdateEx(nName);
        }
        else if (SqlDeal_.mUpdate_ == mSqlDeal)
        {
            this.runUpdate(nValue, nName);
        }
        else if (SqlDeal_.mUpdateSelect_ == mSqlDeal)
        {
            this.updateSelect(nName);
        }
        else if (SqlDeal_.mUpdateWhen_ == mSqlDeal)
        {
            this.updateWhen(nValue);
        }
        else if (SqlDeal_.mUpdateThen_ == mSqlDeal)
        {
            this.updateThen(nValue, nName);
        }
        else
        {
        }
		return nValue;
	}

	@Override
	public byte serialize(byte nValue, String nName) {
		return this.serialize(nValue, nName, SqlFieldId_.mNone_);
	}

	@Override
	public void serialize_8(List<Byte> nValue, String nName) {
        if (SqlDeal_.mWhere_ == mSqlDeal)
        {
            this.runWhere(nValue, nName);
        }
	}

	@Override
	public byte[] serialize(byte[] nValue, String nName, int nSqlFieldId) {
        if (SqlDeal_.mCreate_ == mSqlDeal)
        {
            this.createBlob(nName);
        }
        else if (SqlDeal_.mSelect_ == mSqlDeal)
        {
            this.selectBlob(nName);
        }
        else if (SqlDeal_.mInsertUpdateE_ == mSqlDeal)
        {
            this.insertUpdateEBlob(nValue, nName);
        }
        else if (SqlDeal_.mInsertUpdateEx_ == mSqlDeal)
        {
            this.insertUpdateExBlob(nName);
        }
		return nValue;
	}

	@Override
	public byte[] serialize(byte[] nValue, String nName) {
		return this.serialize(nValue, nName, SqlFieldId_.mNone_);
	}

	@Override
	public short serialize(short nValue, String nName, int nSqlFieldId) {
        if (SqlDeal_.mCreate_ == mSqlDeal)
        {
            this.runCreate("INT(10)", nName, nSqlFieldId);
        }
        else if ((SqlDeal_.mPrimary_ == mSqlDeal) && ((nSqlFieldId & SqlFieldId_.mPrimary_) > 0))
        {
            this.runPrimary(nName);
        }
        else if (SqlDeal_.mSelect_ == mSqlDeal)
        {
            this.runSelect(nName);
        }
        else if (SqlDeal_.mWhere_ == mSqlDeal)
        {
            this.runWhere(nValue, nName);
        }
        else if (SqlDeal_.mInsert_ == mSqlDeal)
        {
            this.runInsert(nValue);
        }
        else if (SqlDeal_.mInsertUpdate_ == mSqlDeal)
        {
            this.runInsertUpdate(nName);
        }
        else if (SqlDeal_.mInsertUpdateE_ == mSqlDeal)
        {
            this.runInsertUpdateE(nName, nValue);
        }
        else if (SqlDeal_.mInsertUpdateEx_ == mSqlDeal)
        {
            this.runInsertUpdateEx(nName);
        }
        else if (SqlDeal_.mUpdate_ == mSqlDeal)
        {
            this.runUpdate(nValue, nName);
        }
        else if (SqlDeal_.mUpdateSelect_ == mSqlDeal)
        {
            this.updateSelect(nName);
        }
        else if (SqlDeal_.mUpdateWhen_ == mSqlDeal)
        {
            this.updateWhen(nValue);
        }
        else if (SqlDeal_.mUpdateThen_ == mSqlDeal)
        {
            this.updateThen(nValue, nName);
        }
        else
        {
        }
		return nValue;
	}

	@Override
	public short serialize(short nValue, String nName) {
		return this.serialize(nValue, nName, SqlFieldId_.mNone_);
	}

	@Override
	public void serialize_16(List<Short> nValue, String nName) {
        if (SqlDeal_.mWhere_ == mSqlDeal)
        {
            this.runWhere(nValue, nName);
        }
	}

	@Override
	public int serialize(int nValue, String nName, int nSqlFieldId) {
        if (SqlDeal_.mCreate_ == mSqlDeal)
        {
            this.runCreate("BIGINT", nName, nSqlFieldId);
        }
        else if ((SqlDeal_.mPrimary_ == mSqlDeal) && ((nSqlFieldId & SqlFieldId_.mPrimary_) > 0))
        {
            this.runPrimary(nName);
        }
        else if (SqlDeal_.mSelect_ == mSqlDeal)
        {
            this.runSelect(nName);
        }
        else if (SqlDeal_.mWhere_ == mSqlDeal)
        {
            this.runWhere(nValue, nName);
        }
        else if (SqlDeal_.mInsert_ == mSqlDeal)
        {
            this.runInsert(nValue);
        }
        else if (SqlDeal_.mInsertUpdate_ == mSqlDeal)
        {
            this.runInsertUpdate(nName);
        }
        else if (SqlDeal_.mInsertUpdateE_ == mSqlDeal)
        {
            this.runInsertUpdateE(nName, nValue);
        }
        else if (SqlDeal_.mInsertUpdateEx_ == mSqlDeal)
        {
            this.runInsertUpdateEx(nName);
        }
        else if (SqlDeal_.mUpdate_ == mSqlDeal)
        {
            this.runUpdate(nValue, nName);
        }
        else if (SqlDeal_.mUpdateSelect_ == mSqlDeal)
        {
            this.updateSelect(nName);
        }
        else if (SqlDeal_.mUpdateWhen_ == mSqlDeal)
        {
            this.updateWhen(nValue);
        }
        else if (SqlDeal_.mUpdateThen_ == mSqlDeal)
        {
            this.updateThen(nValue, nName);
        }
        else
        {
        }
		return nValue;
	}

	@Override
	public int serialize(int nValue, String nName) {
		return this.serialize(nValue, nName, SqlFieldId_.mNone_);
	}

	@Override
	public void serialize_32(List<Integer> nValue, String nName) {
        if (SqlDeal_.mWhere_ == mSqlDeal)
        {
            this.runWhere(nValue, nName);
        }
	}

	@Override
	public long serialize(long nValue, String nName, int nSqlFieldId) {
        if (SqlDeal_.mCreate_ == mSqlDeal)
        {
            this.runCreate("BIGINT UNSIGNED", nName, nSqlFieldId);
        }
        else if ((SqlDeal_.mPrimary_ == mSqlDeal) && ((nSqlFieldId & SqlFieldId_.mPrimary_) > 0))
        {
            this.runPrimary(nName);
        }
        else if (SqlDeal_.mSelect_ == mSqlDeal)
        {
            this.runSelect(nName);
        }
        else if (SqlDeal_.mWhere_ == mSqlDeal)
        {
            this.runWhere(nValue, nName);
        }
        else if (SqlDeal_.mInsert_ == mSqlDeal)
        {
            this.runInsert(nValue);
        }
        else if (SqlDeal_.mInsertUpdate_ == mSqlDeal)
        {
            this.runInsertUpdate(nName);
        }
        else if (SqlDeal_.mInsertUpdateE_ == mSqlDeal)
        {
            this.runInsertUpdateE(nName, nValue);
        }
        else if (SqlDeal_.mInsertUpdateEx_ == mSqlDeal)
        {
            this.runInsertUpdateEx(nName);
        }
        else if (SqlDeal_.mUpdate_ == mSqlDeal)
        {
            this.runUpdate(nValue, nName);
        }
        else if (SqlDeal_.mUpdateSelect_ == mSqlDeal)
        {
            this.updateSelect(nName);
        }
        else if (SqlDeal_.mUpdateWhen_ == mSqlDeal)
        {
            this.updateWhen(nValue);
        }
        else if (SqlDeal_.mUpdateThen_ == mSqlDeal)
        {
            this.updateThen(nValue, nName);
        }
        else
        {
        }
		return nValue;
	}

	@Override
	public long serialize(long nValue, String nName) {
		return this.serialize(nValue, nName, SqlFieldId_.mNone_);
	}

	@Override
	public void serialize_64(List<Long> nValue, String nName) {
        if (SqlDeal_.mWhere_ == mSqlDeal)
        {
            this.runWhere(nValue, nName);
        }
	}

	@Override
	public float serialize(float nValue, String nName, int nSqlFieldId) {
        if (SqlDeal_.mCreate_ == mSqlDeal)
        {
            this.runCreate("FLOAT", nName, nSqlFieldId);
        }
        else if ((SqlDeal_.mPrimary_ == mSqlDeal) && ((nSqlFieldId & SqlFieldId_.mPrimary_) > 0))
        {
            this.runPrimary(nName);
        }
        else if (SqlDeal_.mSelect_ == mSqlDeal)
        {
            this.runSelect(nName);
        }
        else if (SqlDeal_.mWhere_ == mSqlDeal)
        {
            this.runWhere(nValue, nName);
        }
        else if (SqlDeal_.mInsert_ == mSqlDeal)
        {
            this.runInsert(nValue);
        }
        else if (SqlDeal_.mInsertUpdate_ == mSqlDeal)
        {
            this.runInsertUpdate(nName);
        }
        else if (SqlDeal_.mInsertUpdateE_ == mSqlDeal)
        {
            this.runInsertUpdateE(nName, nValue);
        }
        else if (SqlDeal_.mInsertUpdateEx_ == mSqlDeal)
        {
            this.runInsertUpdateEx(nName);
        }
        else if (SqlDeal_.mUpdate_ == mSqlDeal)
        {
            this.runUpdate(nValue, nName);
        }
        else if (SqlDeal_.mUpdateSelect_ == mSqlDeal)
        {
            this.updateSelect(nName);
        }
        else if (SqlDeal_.mUpdateWhen_ == mSqlDeal)
        {
            this.updateWhen(nValue);
        }
        else if (SqlDeal_.mUpdateThen_ == mSqlDeal)
        {
            this.updateThen(nValue, nName);
        }
        else
        {
        }
        return nValue;
	}

	@Override
	public float serialize(float nValue, String nName) {
		return this.serialize(nValue, nName, SqlFieldId_.mNone_);
	}

	@Override
	public void serialize_f(List<Float> nValue, String nName) {
        if (SqlDeal_.mWhere_ == mSqlDeal)
        {
            this.runWhere(nValue, nName);
        }
	}

	@Override
	public double serialize(double nValue, String nName, int nSqlFieldId) {
        if (SqlDeal_.mCreate_ == mSqlDeal)
        {
            this.runCreate("DOUBLE", nName, nSqlFieldId);
        }
        else if ((SqlDeal_.mPrimary_ == mSqlDeal) && ((nSqlFieldId & SqlFieldId_.mPrimary_) > 0))
        {
            this.runPrimary(nName);
        }
        else if (SqlDeal_.mSelect_ == mSqlDeal)
        {
            this.runSelect(nName);
        }
        else if (SqlDeal_.mWhere_ == mSqlDeal)
        {
            this.runWhere(nValue, nName);
        }
        else if (SqlDeal_.mInsert_ == mSqlDeal)
        {
            this.runInsert(nValue);
        }
        else if (SqlDeal_.mInsertUpdate_ == mSqlDeal)
        {
            this.runInsertUpdate(nName);
        }
        else if (SqlDeal_.mInsertUpdateE_ == mSqlDeal)
        {
            this.runInsertUpdateE(nName, nValue);
        }
        else if (SqlDeal_.mInsertUpdateEx_ == mSqlDeal)
        {
            this.runInsertUpdateEx(nName);
        }
        else if (SqlDeal_.mUpdate_ == mSqlDeal)
        {
            this.runUpdate(nValue, nName);
        }
        else if (SqlDeal_.mUpdateSelect_ == mSqlDeal)
        {
            this.updateSelect(nName);
        }
        else if (SqlDeal_.mUpdateWhen_ == mSqlDeal)
        {
            this.updateWhen(nValue);
        }
        else if (SqlDeal_.mUpdateThen_ == mSqlDeal)
        {
            this.updateThen(nValue, nName);
        }
        else
        {
        }
		return nValue;
	}

	@Override
	public double serialize(double nValue, String nName) {
		return this.serialize(nValue, nName, SqlFieldId_.mNone_);
	}

	@Override
	public void serialize_d(List<Double> nValue, String nName) {
        if (SqlDeal_.mWhere_ == mSqlDeal)
        {
            this.runWhere(nValue, nName);
        }
	}

	@Override
	public String serialize(String nValue, String nName, int nSqlFieldId) {
        if (SqlDeal_.mCreate_ == mSqlDeal)
        {
            this.runCreate("VARCHAR(255)", nName, nSqlFieldId);
        }
        else if ((SqlDeal_.mPrimary_ == mSqlDeal) && ((nSqlFieldId & SqlFieldId_.mPrimary_) > 0))
        {
            this.runPrimary(nName);
        }
        else if (SqlDeal_.mSelect_ == mSqlDeal)
        {
            this.runSelect(nName);
        }
        else if (SqlDeal_.mWhere_ == mSqlDeal)
        {
            this.runWhere(nValue, nName);
        }
        else if (SqlDeal_.mInsert_ == mSqlDeal)
        {
            this.runInsert(nValue);
        }
        else if (SqlDeal_.mInsertUpdate_ == mSqlDeal)
        {
            this.runInsertUpdate(nName);
        }
        else if (SqlDeal_.mInsertUpdateE_ == mSqlDeal)
        {
            this.runInsertUpdateE(nName, nValue);
        }
        else if (SqlDeal_.mInsertUpdateEx_ == mSqlDeal)
        {
            this.runInsertUpdateEx(nName);
        }
        else if (SqlDeal_.mUpdate_ == mSqlDeal)
        {
            this.runUpdate(nValue, nName);
        }
        else if (SqlDeal_.mUpdateSelect_ == mSqlDeal)
        {
            this.updateSelect(nName);
        }
        else if (SqlDeal_.mUpdateWhen_ == mSqlDeal)
        {
            this.updateWhen(nValue);
        }
        else if (SqlDeal_.mUpdateThen_ == mSqlDeal)
        {
            this.updateThen(nValue, nName);
        }
        else
        {
        }
        return nValue;
	}

	@Override
	public String serialize(String nValue, String nName) {
		return this.serialize(nValue, nName, SqlFieldId_.mNone_);
	}

	@Override
	public void serialize_s(List<String> nValue, String nName) {
        if (SqlDeal_.mWhere_ == mSqlDeal)
        {
            this.runWhere(nValue, nName);
        }
	}

	@Override
	public <T> T serialize(T nValue, String nName, int nSqlFieldId) {
		return null;
	}

	@Override
	public <T> T serialize(T nValue, String nName) {
		return null;
	}

	@Override
	public <T extends ISqlStream> void serialize_t(List<T> nValue,
			String nName, Class<T> nClass) {
        if (SqlDeal_.mSelect_ == mSqlDeal)
        {
            this.runSelect(nValue, nClass);
        }
        else if (SqlDeal_.mInsert_ == mSqlDeal)
        {
            this.runInsert(nValue);
        }
        else if (SqlDeal_.mInsertUpdate_ == mSqlDeal)
        {
            this.runInsertUpdate(nValue);
        }
        else if (SqlDeal_.mUpdate_ == mSqlDeal)
        {
            this.runUpdate(nValue, nName);
        }
        else
        {
        }
	}
	
    public void addHeadstream(ISqlHeadstream nSqlStream)
    {
        int sqlType_ = nSqlStream.sqlType();
        if (SqlType_.mCreate_ == sqlType_)
        {
            this.runCreate(nSqlStream);
        }
        else if (SqlType_.mSelect_ == sqlType_)
        {
            this.runSelect(nSqlStream);
        }
        else if (SqlType_.mInsert_ == sqlType_)
        {
            this.runInsert(nSqlStream);
        }
        else if (SqlType_.mInsertUpdate_ == sqlType_)
        {
            this.runInsertUpdate(nSqlStream);
        }
        else if (SqlType_.mInsertUpdateEx_ == sqlType_)
        {
            this.runInsertUpdateEx(nSqlStream);
        }
        else if (SqlType_.mUpdate_ == sqlType_)
        {
            this.runUpdate(nSqlStream);
        }
        else if (SqlType_.mDelete_ == sqlType_)
        {
            this.runDelete(nSqlStream);
        }
        else
        {
        }
    }
    
    public void runCreate(ISqlHeadstream nSqlHeadstream)
    {
        mValue += "CREATE TABLE ";
        mValue += mFieldCharacter;
        mValue += nSqlHeadstream.tableName();
        mValue += mFieldCharacter;
        mValue += "(";
        mBeg = true;
        mSqlDeal = SqlDeal_.mCreate_;
        nSqlHeadstream.runSelect(this);
        mBeg = true;
        mEnd = false;
        mSqlDeal = SqlDeal_.mPrimary_;
        nSqlHeadstream.runSelect(this);
        if (mEnd)
        {
            mValue += ")";
        }
        mValue += ")ENGINE=MYISAM DEFAULT CHARSET=utf8;";
        mSqlDeal = SqlDeal_.mNone_;
    }
    
    void runCreate(String nValue, String nName, int nSqlFieldId)
    {
        if (false == mBeg)
        {
            mValue += ",";
        }
        mValue += mFieldCharacter;
        mValue += nName;
        mValue += mFieldCharacter;
        mValue += " ";
        mValue += nValue;
        if ((nSqlFieldId & SqlFieldId_.mZeroFill_) > 0)
        {
            mValue += " ZEROFILL";
        }
        if ((nSqlFieldId & SqlFieldId_.mBinary_) > 0)
        {
            mValue += " BINARY";
        }
        if ((nSqlFieldId & SqlFieldId_.mNotNull_) > 0)
        {
            mValue += " NOT NULL";
        }
        if ((nSqlFieldId & SqlFieldId_.mAutoIncremet_) > 0)
        {
            mValue += " AUTO_INCREMENT";
        }
        if (mBeg)
        {
            mBeg = false;
        }
    }
    
    void runCreate(String nValue, String nName)
    {
    	this.runCreate(nValue, nName, SqlFieldId_.mNone_);
    }
    
    void createBlob(String nName)
    {
        if (false == mBeg)
        {
            mValue += ",";
        }
        mValue += mFieldCharacter;
        mValue += String.format("%s_i", nName);
        mValue += mFieldCharacter;
        mValue += " INT(10) ZEROFILL NOT NULL,";
        mValue += mFieldCharacter;
        mValue += nName;
        mValue += mFieldCharacter;
        mValue += " BLOB NULL";
        if (mBeg)
        {
            mBeg = false;
        }
    }
    
    void runPrimary(String nName)
    {
        if (false == mBeg)
        {
            mValue += ",";
        }
        else
        {
            mValue += ", PRIMARY KEY (";
        }
        mValue += mFieldCharacter;
        mValue += nName;
        mValue += mFieldCharacter;
        mEnd = true;
        if (mBeg)
        {
            mBeg = false;
        }
    }
    
    public void runSelect(ISqlHeadstream nSqlHeadstream)
    {
        mValue += "SELECT ";
        mBeg = true;
        mSqlDeal = SqlDeal_.mSelect_;
        nSqlHeadstream.runSelect(this);
        mValue += " FROM ";
        mValue += mFieldCharacter;
        mValue += nSqlHeadstream.tableName();
        mValue += mFieldCharacter;
        mValue += " ";
        mSqlDeal = SqlDeal_.mWhere_;
        nSqlHeadstream.runWhere(this);
        mSqlDeal = SqlDeal_.mNone_;
    }
    
    void runSelect(String nName)
    {
        if (false == mBeg)
        {
            mValue += ",";
        }
        mValue += mFieldCharacter;
        mValue += nName;
        mValue += mFieldCharacter;
        if (mBeg)
        {
            mBeg = false;
        }
    }
    
    void selectBlob(String nName)
    {
        if (false == mBeg)
        {
            mValue += ",";
        }
        mValue += mFieldCharacter;
        mValue += String.format("%s_i", nName);
        mValue += mFieldCharacter;
        mValue += ",";
        mValue += mFieldCharacter;
        mValue += nName;
        mValue += mFieldCharacter;
        if (mBeg)
        {
            mBeg = false;
        }
    }
    
	<T extends ISqlStream> void runSelect(List<T> nValue, Class<T> nClass)
    {
        if (nValue.size() > 0)
        {
        	nValue.get(0).runSelect(this);
        	return;
        }
		try {
			T t_ = nClass.newInstance();
			t_.runSelect(this);
		} catch (InstantiationException e) {
			e.printStackTrace();
		} catch (IllegalAccessException e) {
			e.printStackTrace();
		}
    }
    
	<T> void runWhere(T nValue, String nName)
    {
        mValue += nName;
        mValue += mValueCharacter;
        mValue += nValue.toString();
        mValue += mValueCharacter;
        mValue += " ";
    }
    
    public void runInsert(ISqlHeadstream nSqlHeadstream)
    {
        mValue += "INSERT INTO ";
        mValue += mFieldCharacter;
        mValue += nSqlHeadstream.tableName();
        mValue += mFieldCharacter;
        mValue += " (";
        mBeg = true;
        mSqlDeal = SqlDeal_.mSelect_;
        nSqlHeadstream.runSelect(this);
        mValue += ") VALUES (";
        mBeg = true;
        mSqlDeal = SqlDeal_.mInsert_;
        nSqlHeadstream.runSelect(this);
        mValue += ") ";
        mSqlDeal = SqlDeal_.mWhere_;
        nSqlHeadstream.runWhere(this);
        mSqlDeal = SqlDeal_.mNone_;
    }
    
	<T> void runInsert(T nValue)
    {
        if (false == mBeg)
        {
            mValue += ",";
        }
        mValue += mValueCharacter;
        mValue += nValue.toString();
        mValue += mValueCharacter;
        if (mBeg)
        {
            mBeg = false;
        }
    }
    
	<T extends ISqlStream> void runInsert(List<T> nValue)
    {
        Boolean temp_ = false;
        for (T i : nValue)
        {
            if (temp_)
            {
                mValue += "),(";
                mBeg = true;
            }
            i.runSelect(this);
            temp_ = true;
        }
    }
    
    public void runInsertUpdate(ISqlHeadstream nSqlHeadstream)
    {
        mValue += "INSERT INTO ";
        mValue += mFieldCharacter;
        mValue += nSqlHeadstream.tableName();
        mValue += mFieldCharacter;
        mValue += " (";
        mBeg = true;
        mSqlDeal = SqlDeal_.mSelect_;
        nSqlHeadstream.runSelect(this);
        mValue += ") VALUES (";
        mBeg = true;
        mSqlDeal = SqlDeal_.mInsert_;
        nSqlHeadstream.runSelect(this);
        mValue += ") ";
        mSqlDeal = SqlDeal_.mInsertUpdate_;
        nSqlHeadstream.runSelect(this);
        mSqlDeal = SqlDeal_.mWhere_;
        nSqlHeadstream.runWhere(this);
        mSqlDeal = SqlDeal_.mNone_;
    }
    
    void runInsertUpdate(String nName)
    {
        if (false == mBeg)
        {
            mValue += ",";
        }
        mValue += mFieldCharacter;
        mValue += nName;
        mValue += mFieldCharacter;
        mValue += "=VALUES(";
        mValue += mFieldCharacter;
        mValue += nName;
        mValue += mFieldCharacter;
        mValue += ")";
        if (mBeg)
        {
            mBeg = false;
        }
    }
    
	<T extends ISqlStream> void runInsertUpdate(List<T> nValue)
    {
        mValue += "ON DUPLICATE KEY UPDATE ";
        mBeg = true;
        for (T i : nValue)
        {
            i.runSelect(this);
            break;
        }
    }
    
    public void runInsertUpdateEx(ISqlHeadstream nSqlHeadstream)
    {
        mValue += "INSERT INTO ";
        mValue += mFieldCharacter;
        mValue += nSqlHeadstream.tableName();
        mValue += mFieldCharacter;
        mValue += " VALUES (";
        mBeg = true;
        mSqlDeal = SqlDeal_.mInsertUpdateE_;
        nSqlHeadstream.runSelect(this);
        mValue += ") ON DUPLICATE KEY UPDATE ";
        mBeg = true;
        mSqlDeal = SqlDeal_.mInsertUpdateEx_;
        nSqlHeadstream.runSelect(this);
        mSqlDeal = SqlDeal_.mWhere_;
        nSqlHeadstream.runWhere(this);
        mSqlDeal = SqlDeal_.mNone_;
    }
    
	<T> void runInsertUpdateE(String nName, T nValue)
    {
        if (false == mBeg)
        {
            mValue += ",";
        }
        mValue += mUpdateCharacter;
        mValue += nName;
        if (mBeg)
        {
            mBeg = false;
        }
        SqlParameter sqlParameter_ = new SqlParameter(nName, nValue);
        mFields.add(sqlParameter_);
    }
    
    void insertUpdateEBlob(byte[] nValue, String nName)
    {
        if (false == mBeg)
        {
            mValue += ",";
        }
        mValue += mUpdateCharacter;
        String name_ = String.format("%s_i", nName);
        mValue += name_;
        mValue += ",";
        mValue += mUpdateCharacter;
        mValue += nName;
        if (mBeg)
        {
            mBeg = false;
        }
        SqlParameter sqlParameter_ = new SqlParameter(name_, nValue.length);
        mFields.add(sqlParameter_);
        sqlParameter_ = new SqlParameter(nName, nValue);
        mFields.add(sqlParameter_);
    }
    
    void runInsertUpdateEx(String nName)
    {
        if (false == mBeg)
        {
            mValue += ",";
        }
        mValue += mFieldCharacter;
        mValue += nName;
        mValue += mFieldCharacter;
        mValue += "=VALUES(";
        mValue += mFieldCharacter;
        mValue += nName;
        mValue += mFieldCharacter;
        mValue += ")";
        if (mBeg)
        {
            mBeg = false;
        }
    }
    
    void insertUpdateExBlob(String nName)
    {
        if (false == mBeg)
        {
            mValue += ",";
        }
        mValue += mFieldCharacter;
        mValue += String.format("%s_i", nName);
        mValue += mFieldCharacter;
        mValue += "=VALUES(";
        mValue += mFieldCharacter;
        mValue += String.format("%s_i", nName);
        mValue += mFieldCharacter;
        mValue += "),";
        mValue += mFieldCharacter;
        mValue += nName;
        mValue += mFieldCharacter;
        mValue += "=VALUES(";
        mValue += mFieldCharacter;
        mValue += nName;
        mValue += mFieldCharacter;
        mValue += ")";
        if (mBeg)
        {
            mBeg = false;
        }
    }
    
    public void runUpdate(ISqlHeadstream nSqlHeadstream)
    {
        mValue += "UPDATE ";
        mValue += mFieldCharacter;
        mValue += nSqlHeadstream.tableName();
        mValue += mFieldCharacter;
        mValue += " SET ";
        mBeg = true;
        mSqlDeal = SqlDeal_.mUpdate_;
        nSqlHeadstream.runSelect(this);
        mSqlDeal = SqlDeal_.mWhere_;
        mValue += " ";
        nSqlHeadstream.runWhere(this);
        mSqlDeal = SqlDeal_.mNone_;
    }
    
	<T> void runUpdate(T nValue, String nName)
    {
        if (false == mBeg)
        {
            mValue += ",";
        }
        mValue += mFieldCharacter;
        mValue += nName;
        mValue += mFieldCharacter;
        mValue += "=";
        mValue += mValueCharacter;
        mValue += nValue.toString();
        mValue += mValueCharacter;
        if (mBeg)
        {
            mBeg = false;
        }
    }
    
	<T extends ISqlStream> void runUpdate(List<T> nValue, String nName)
    {
        mUpdate.clear();
        mSqlDeal = SqlDeal_.mUpdateSelect_;
        for (T i : nValue)
        {
            i.runSelect(this);
            break;
        }
        Boolean temp_ = true;
        for (String i : mUpdate)
        {
            mName = i;
            if (false == temp_)
            {
                mValue += ",";
            }
            mValue += mFieldCharacter;
            mValue += mName;
            mValue += mFieldCharacter;
            mValue += "= CASE ";
            mSqlDeal = SqlDeal_.mSelect_;
            mBeg = true;
            for (T j : nValue)
            {
                j.runWhen(this);
                break;
            }
            for (T j : nValue)
            {
                mSqlDeal = SqlDeal_.mUpdateWhen_;
                mValue += " WHEN ";
                j.runWhen(this);
                mSqlDeal = SqlDeal_.mUpdateThen_;
                mValue += "THEN ";
                j.runSelect(this);
            }
            mValue += " END";
            if (temp_)
            {
                temp_ = false;
            }
        }
        mValue += " WHERE ";
        mSqlDeal = SqlDeal_.mSelect_;
        mBeg = true;
        for (T i : nValue)
        {
            i.runWhen(this);
            break;
        }
        mSqlDeal = SqlDeal_.mInsert_;
        mBeg = true;
        mValue += " IN (";
        for (T i : nValue)
        {
            i.runWhen(this);
        }
        mValue += ")";
    }
    
    void updateSelect(String nName)
    {
        mUpdate.add(nName);
    }
    
	<T> void updateWhen(T nValue)
    {
        mValue += mValueCharacter;
        mValue += nValue.toString();
        mValue += mValueCharacter;
        mValue += " ";
    }
    
	<T> void updateThen(T nValue, String nName)
    {
        if (mName == nName)
        {
            mValue += mValueCharacter;
            mValue += nValue.toString();
            mValue += mValueCharacter;
        }
    }
    
    public void runDelete(ISqlHeadstream nSqlHeadstream)
    {
        mValue += "DELETE FROM ";
        mValue += mFieldCharacter;
        mValue += nSqlHeadstream.tableName();
        mValue += mFieldCharacter;
        mValue += " ";
        mSqlDeal = SqlDeal_.mWhere_;
        nSqlHeadstream.runWhere(this);
        mSqlDeal = SqlDeal_.mNone_;
    }
    
    <T> void runWhere(List<T> nValue, String nName)
    {
    	Boolean beg_ = true;
        mValue += nName;
        mValue += "(";
        for (T i : nValue)
        {
            if (false == beg_)
            {
                mValue += ",";
            }
            mValue += mValueCharacter;
            mValue += i.toString();
            mValue += mValueCharacter;
            beg_ = false;
        }
        mValue += ") ";
    }
    
    public List<SqlParameter> getFields()
    {
        return mFields;
    }
    
    public String sqlCommand()
    {
        return mValue;
    }

    public SqlCommand()
    {
        mFields = new ArrayList<SqlParameter>();
        mUpdate = new ArrayList<String>();
        mSqlDeal = SqlDeal_.mNone_;
        mValue = null;
        mName = null;
        mBeg = false;
        mEnd = false;
    }
	
    List<SqlParameter> mFields;
    List<String> mUpdate;
    int mSqlDeal;
    String mValue;
    String mName;
    Boolean mBeg;
    Boolean mEnd;
    
	static final String mValueCharacter = "'";
	static final String mFieldCharacter = "";
	static final String mUpdateCharacter = "?";

}
