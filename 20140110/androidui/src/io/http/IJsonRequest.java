package io.http;

import serialize.json.IJsonHeadstream;

public interface IJsonRequest extends IJsonHeadstream {
	
	IJsonRespone getRespone();
	
}
