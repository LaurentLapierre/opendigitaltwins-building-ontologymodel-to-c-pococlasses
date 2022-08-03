using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class AbsoluteHumiditySetpoint : HumiditySetpoint, IEquatable<AbsoluteHumiditySetpoint>
    {
        public AbsoluteHumiditySetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:AbsoluteHumiditySetpoint;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as AbsoluteHumiditySetpoint);
        }

        public bool Equals(AbsoluteHumiditySetpoint? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(AbsoluteHumiditySetpoint? left, AbsoluteHumiditySetpoint? right)
        {
            return EqualityComparer<AbsoluteHumiditySetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(AbsoluteHumiditySetpoint? left, AbsoluteHumiditySetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}