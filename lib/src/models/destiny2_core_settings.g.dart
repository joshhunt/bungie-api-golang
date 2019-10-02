// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'destiny2_core_settings.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Destiny2CoreSettings _$Destiny2CoreSettingsFromJson(Map<String, dynamic> json) {
  return Destiny2CoreSettings()
    ..collectionRootNode = json['collectionRootNode'] as int
    ..badgesRootNode = json['badgesRootNode'] as int
    ..recordsRootNode = json['recordsRootNode'] as int
    ..medalsRootNode = json['medalsRootNode'] as int
    ..currentRankProgressionHashes =
        (json['currentRankProgressionHashes'] as List)
            ?.map((e) => e as int)
            ?.toList()
    ..undiscoveredCollectibleImage =
        json['undiscoveredCollectibleImage'] as String
    ..ammoTypeHeavyIcon = json['ammoTypeHeavyIcon'] as String
    ..ammoTypeSpecialIcon = json['ammoTypeSpecialIcon'] as String
    ..ammoTypePrimaryIcon = json['ammoTypePrimaryIcon'] as String
    ..currentSeasonalArtifactHash = json['currentSeasonalArtifactHash'] as int
    ..currentSeasonHash = json['currentSeasonHash'] as int
    ..futureSeasonHashes =
        (json['futureSeasonHashes'] as List)?.map((e) => e as int)?.toList();
}

Map<String, dynamic> _$Destiny2CoreSettingsToJson(
        Destiny2CoreSettings instance) =>
    <String, dynamic>{
      'collectionRootNode': instance.collectionRootNode,
      'badgesRootNode': instance.badgesRootNode,
      'recordsRootNode': instance.recordsRootNode,
      'medalsRootNode': instance.medalsRootNode,
      'currentRankProgressionHashes': instance.currentRankProgressionHashes,
      'undiscoveredCollectibleImage': instance.undiscoveredCollectibleImage,
      'ammoTypeHeavyIcon': instance.ammoTypeHeavyIcon,
      'ammoTypeSpecialIcon': instance.ammoTypeSpecialIcon,
      'ammoTypePrimaryIcon': instance.ammoTypePrimaryIcon,
      'currentSeasonalArtifactHash': instance.currentSeasonalArtifactHash,
      'currentSeasonHash': instance.currentSeasonHash,
      'futureSeasonHashes': instance.futureSeasonHashes
    };
