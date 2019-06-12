
import 'package:json_annotation/json_annotation.dart';
part 'dictionary_ofint32_andstring_response.g.dart';

/** Look at the Response property for more information about the nature of this response */
@JsonSerializable()
class DictionaryOfint32AndstringResponse{
	
	/**  */
	@JsonKey(name:'Response')
	Map<String, String> response;
	
	/**  */
	@JsonKey(name:'ErrorCode')
	int errorCode;
	
	/**  */
	@JsonKey(name:'ThrottleSeconds')
	int throttleSeconds;
	
	/**  */
	@JsonKey(name:'ErrorStatus')
	String errorStatus;
	
	/**  */
	@JsonKey(name:'Message')
	String message;
	
	/**  */
	@JsonKey(name:'MessageData')
	Map<String, String> messageData;
	
	/**  */
	@JsonKey(name:'DetailedErrorTrace')
	String detailedErrorTrace;
	DictionaryOfint32AndstringResponse({
		Map<String, String> this.response,
		int this.errorCode,
		int this.throttleSeconds,
		String this.errorStatus,
		String this.message,
		Map<String, String> this.messageData,
		String this.detailedErrorTrace,
	});

	factory DictionaryOfint32AndstringResponse.fromJson(Map<String, dynamic> json) => _$DictionaryOfint32AndstringResponseFromJson(json);
	

	Map<String, dynamic> toJson() => _$DictionaryOfint32AndstringResponseToJson(this);
}