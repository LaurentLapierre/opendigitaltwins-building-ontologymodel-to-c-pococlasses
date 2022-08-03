using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class DataSizeSetpoint : QuantitySetpoint, IEquatable<DataSizeSetpoint>
    {
        public DataSizeSetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:DataSizeSetpoint;1";
        [JsonPropertyName("lastValue")]
        public double? LastValue { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as DataSizeSetpoint);
        }

        public bool Equals(DataSizeSetpoint? other)
        {
            return other is not null && base.Equals(other) && LastValue == other.LastValue;
        }

        public static bool operator ==(DataSizeSetpoint? left, DataSizeSetpoint? right)
        {
            return EqualityComparer<DataSizeSetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(DataSizeSetpoint? left, DataSizeSetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), LastValue?.GetHashCode());
        }
    }
}