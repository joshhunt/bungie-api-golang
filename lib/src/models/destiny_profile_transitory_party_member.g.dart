// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'destiny_profile_transitory_party_member.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

DestinyProfileTransitoryPartyMember
    _$DestinyProfileTransitoryPartyMemberFromJson(Map<String, dynamic> json) {
  return DestinyProfileTransitoryPartyMember()
    ..membershipId = json['membershipId'] as String
    ..emblemHash = json['emblemHash'] as int
    ..displayName = json['displayName'] as String
    ..status = json['status'] as int;
}

Map<String, dynamic> _$DestinyProfileTransitoryPartyMemberToJson(
        DestinyProfileTransitoryPartyMember instance) =>
    <String, dynamic>{
      'membershipId': instance.membershipId,
      'emblemHash': instance.emblemHash,
      'displayName': instance.displayName,
      'status': instance.status
    };
