package serialize.sql;

public interface ISqlStream {
	
    void runSelect(ISqlCommand nSqlCommand);

    void runWhen(ISqlCommand nSqlCommand);
    
}
