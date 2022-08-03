using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class VariableFrequencyDrive : ElectricalDistributionEquipment, IEquatable<VariableFrequencyDrive>
    {
        public VariableFrequencyDrive()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:VariableFrequencyDrive;1";
        [JsonPropertyName("type")]
        public VariableFrequencyDriveType? Type { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as VariableFrequencyDrive);
        }

        public bool Equals(VariableFrequencyDrive? other)
        {
            return other is not null && base.Equals(other) && Type == other.Type;
        }

        public static bool operator ==(VariableFrequencyDrive? left, VariableFrequencyDrive? right)
        {
            return EqualityComparer<VariableFrequencyDrive?>.Default.Equals(left, right);
        }

        public static bool operator !=(VariableFrequencyDrive? left, VariableFrequencyDrive? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Type?.GetHashCode());
        }
    }
}