package serialize.sql;

public interface ISqlHeadstream {

    void runSelect(ISqlCommand nSqlCommand);

    void runWhere(ISqlCommand nSqlCommand);

    String tableName();

    int sqlType();
    
}
