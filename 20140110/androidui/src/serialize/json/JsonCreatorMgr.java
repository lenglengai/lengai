package serialize.json;

import java.util.HashMap;
import java.util.Map;

import ui.account.CreateRequestCreator;

import common.utility.GenerateId;

public class JsonCreatorMgr {
	
	public static void runInit() {
		VersionResponseCreator versionResponseCreator = new VersionResponseCreator();
		_register(versionResponseCreator);
		CreateRequestCreator createRequestCreator = new CreateRequestCreator();
		_register(createRequestCreator);
	}
	
	public static void _register(IJsonCreator nJsonCreator) {
        String context = nJsonCreator.getContext();
        int contextId = GenerateId.runCommon(context);
        int newsId = nJsonCreator.getId();
        long id_ = (contextId << 32) + newsId;
		mJsonCreators.put(id_, nJsonCreator);
	}
	
	public static IJsonCreator _getJsonCreator(long nId) {
		return mJsonCreators.get(nId);
	}
	
	static Map<Long, IJsonCreator> mJsonCreators = new HashMap<Long, IJsonCreator>();
	
}
