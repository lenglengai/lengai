package serialize.json;

public abstract class CommonResponseCreator implements IJsonCreator {

	public abstract IJsonResponse createJsonResponse();

	@Override
	public String getContext() {
		return COMMONCONSTS.CONTEXT;
	}

	public abstract int getId();

}
