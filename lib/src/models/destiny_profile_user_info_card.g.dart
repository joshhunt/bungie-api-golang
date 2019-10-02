// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'destiny_profile_user_info_card.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

DestinyProfileUserInfoCard _$DestinyProfileUserInfoCardFromJson(
    Map<String, dynamic> json) {
  return DestinyProfileUserInfoCard()
    ..dateLastPlayed = json['dateLastPlayed'] as String
    ..isOverridden = json['isOverridden'] as bool
    ..isCrossSavePrimary = json['isCrossSavePrimary'] as bool
    ..platformSilver = json['platformSilver'] == null
        ? null
        : DestinyPlatformSilverComponent.fromJson(
            json['platformSilver'] as Map<String, dynamic>)
    ..unpairedGameVersions = json['unpairedGameVersions'] as int
    ..supplementalDisplayName = json['supplementalDisplayName'] as String
    ..iconPath = json['iconPath'] as String
    ..crossSaveOverride = json['crossSaveOverride'] as int
    ..applicableMembershipTypes = (json['applicableMembershipTypes'] as List)
        ?.map((e) => e as int)
        ?.toList()
    ..isPublic = json['isPublic'] as bool
    ..membershipType = json['membershipType'] as int
    ..membershipId = json['membershipId'] as String
    ..displayName = json['displayName'] as String;
}

Map<String, dynamic> _$DestinyProfileUserInfoCardToJson(
        DestinyProfileUserInfoCard instance) =>
    <String, dynamic>{
      'dateLastPlayed': instance.dateLastPlayed,
      'isOverridden': instance.isOverridden,
      'isCrossSavePrimary': instance.isCrossSavePrimary,
      'platformSilver': instance.platformSilver,
      'unpairedGameVersions': instance.unpairedGameVersions,
      'supplementalDisplayName': instance.supplementalDisplayName,
      'iconPath': instance.iconPath,
      'crossSaveOverride': instance.crossSaveOverride,
      'applicableMembershipTypes': instance.applicableMembershipTypes,
      'isPublic': instance.isPublic,
      'membershipType': instance.membershipType,
      'membershipId': instance.membershipId,
      'displayName': instance.displayName
    };
