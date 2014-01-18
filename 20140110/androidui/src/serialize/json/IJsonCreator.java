package serialize.json;

public interface IJsonCreator {
	
	IJsonResponse createJsonResponse();
	
	String getContext();
	
	int getId();
	
}
