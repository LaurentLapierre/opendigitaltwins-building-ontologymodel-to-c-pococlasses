using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class UPS : ElectricalGenerationStorageEquipment, IEquatable<UPS>
    {
        public UPS()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:UPS;1";
        [JsonPropertyName("runtime")]
        public double? Runtime { get; set; }
        [JsonPropertyName("powerOutputKVA")]
        public int? PowerOutputKVA { get; set; }
        [JsonPropertyName("powerOutput")]
        public double? PowerOutput { get; set; }
        [JsonPropertyName("outputVoltage")]
        public double? OutputVoltage { get; set; }
        [JsonPropertyName("outputPhases")]
        public UPSOutputPhases? OutputPhases { get; set; }
        [JsonPropertyName("inputVoltage")]
        public double? InputVoltage { get; set; }
        [JsonPropertyName("inputPhases")]
        public UPSInputPhases? InputPhases { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as UPS);
        }

        public bool Equals(UPS? other)
        {
            return other is not null && base.Equals(other) && Runtime == other.Runtime && PowerOutputKVA == other.PowerOutputKVA && PowerOutput == other.PowerOutput && OutputVoltage == other.OutputVoltage && OutputPhases == other.OutputPhases && InputVoltage == other.InputVoltage && InputPhases == other.InputPhases;
        }

        public static bool operator ==(UPS? left, UPS? right)
        {
            return EqualityComparer<UPS?>.Default.Equals(left, right);
        }

        public static bool operator !=(UPS? left, UPS? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Runtime?.GetHashCode(), PowerOutputKVA?.GetHashCode(), PowerOutput?.GetHashCode(), OutputVoltage?.GetHashCode(), OutputPhases?.GetHashCode(), InputVoltage?.GetHashCode(), InputPhases?.GetHashCode());
        }
    }
}