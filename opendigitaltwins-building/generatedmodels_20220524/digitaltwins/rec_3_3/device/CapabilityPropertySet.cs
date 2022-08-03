using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.core;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class CapabilityPropertySet : PropertySet, IEquatable<CapabilityPropertySet>
    {
        public CapabilityPropertySet()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:CapabilityPropertySet;1";
        [JsonPropertyName("HVACMode")]
        public CapabilityPropertySetHVACMode? HVACMode { get; set; }
        [JsonPropertyName("alarm")]
        public bool? Alarm { get; set; }
        [JsonPropertyName("assetComponent")]
        public CapabilityPropertySetAssetComponent? AssetComponent { get; set; }
        [JsonPropertyName("demand")]
        public bool? Demand { get; set; }
        [JsonPropertyName("effective")]
        public bool? Effective { get; set; }
        [JsonPropertyName("electricalPhase")]
        public CapabilityPropertySetElectricalPhase? ElectricalPhase { get; set; }
        [JsonPropertyName("limit")]
        public CapabilityPropertySetLimit? Limit { get; set; }
        [JsonPropertyName("occupancyMode")]
        public CapabilityPropertySetOccupancyMode? OccupancyMode { get; set; }
        [JsonPropertyName("phenomenon")]
        public CapabilityPropertySetPhenomenon? Phenomenon { get; set; }
        [JsonPropertyName("position")]
        public CapabilityPropertySetPosition? Position { get; set; }
        [JsonPropertyName("stage")]
        public int? Stage { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as CapabilityPropertySet);
        }

        public bool Equals(CapabilityPropertySet? other)
        {
            return other is not null && base.Equals(other) && HVACMode == other.HVACMode && Alarm == other.Alarm && AssetComponent == other.AssetComponent && Demand == other.Demand && Effective == other.Effective && ElectricalPhase == other.ElectricalPhase && Limit == other.Limit && OccupancyMode == other.OccupancyMode && Phenomenon == other.Phenomenon && Position == other.Position && Stage == other.Stage;
        }

        public static bool operator ==(CapabilityPropertySet? left, CapabilityPropertySet? right)
        {
            return EqualityComparer<CapabilityPropertySet?>.Default.Equals(left, right);
        }

        public static bool operator !=(CapabilityPropertySet? left, CapabilityPropertySet? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), HVACMode?.GetHashCode(), Alarm?.GetHashCode(), AssetComponent?.GetHashCode(), Demand?.GetHashCode(), Effective?.GetHashCode(), ElectricalPhase?.GetHashCode(), Limit?.GetHashCode(), OccupancyMode?.GetHashCode(), Phenomenon?.GetHashCode(), Position?.GetHashCode(), Stage?.GetHashCode());
        }
    }
}