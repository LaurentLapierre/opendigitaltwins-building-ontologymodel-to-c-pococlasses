using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class StaticPressureSetpoint : PressureSetpoint, IEquatable<StaticPressureSetpoint>
    {
        public StaticPressureSetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:StaticPressureSetpoint;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as StaticPressureSetpoint);
        }

        public bool Equals(StaticPressureSetpoint? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(StaticPressureSetpoint? left, StaticPressureSetpoint? right)
        {
            return EqualityComparer<StaticPressureSetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(StaticPressureSetpoint? left, StaticPressureSetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}