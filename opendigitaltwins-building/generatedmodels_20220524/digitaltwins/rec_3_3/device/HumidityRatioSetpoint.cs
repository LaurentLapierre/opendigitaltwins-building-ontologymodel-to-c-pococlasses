using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class HumidityRatioSetpoint : HumiditySetpoint, IEquatable<HumidityRatioSetpoint>
    {
        public HumidityRatioSetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:HumidityRatioSetpoint;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as HumidityRatioSetpoint);
        }

        public bool Equals(HumidityRatioSetpoint? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(HumidityRatioSetpoint? left, HumidityRatioSetpoint? right)
        {
            return EqualityComparer<HumidityRatioSetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(HumidityRatioSetpoint? left, HumidityRatioSetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}