using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class RelativeHumiditySetpoint : HumiditySetpoint, IEquatable<RelativeHumiditySetpoint>
    {
        public RelativeHumiditySetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:RelativeHumiditySetpoint;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as RelativeHumiditySetpoint);
        }

        public bool Equals(RelativeHumiditySetpoint? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(RelativeHumiditySetpoint? left, RelativeHumiditySetpoint? right)
        {
            return EqualityComparer<RelativeHumiditySetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(RelativeHumiditySetpoint? left, RelativeHumiditySetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}