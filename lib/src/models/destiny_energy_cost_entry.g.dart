// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'destiny_energy_cost_entry.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

DestinyEnergyCostEntry _$DestinyEnergyCostEntryFromJson(
    Map<String, dynamic> json) {
  return DestinyEnergyCostEntry()
    ..energyCost = json['energyCost'] as int
    ..energyTypeHash = json['energyTypeHash'] as int
    ..energyType = json['energyType'] as int;
}

Map<String, dynamic> _$DestinyEnergyCostEntryToJson(
        DestinyEnergyCostEntry instance) =>
    <String, dynamic>{
      'energyCost': instance.energyCost,
      'energyTypeHash': instance.energyTypeHash,
      'energyType': instance.energyType
    };
