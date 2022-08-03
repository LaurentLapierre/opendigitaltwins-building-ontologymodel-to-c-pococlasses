using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class PositionSetpoint : PercentSetpoint, IEquatable<PositionSetpoint>
    {
        public PositionSetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:PositionSetpoint;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as PositionSetpoint);
        }

        public bool Equals(PositionSetpoint? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(PositionSetpoint? left, PositionSetpoint? right)
        {
            return EqualityComparer<PositionSetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(PositionSetpoint? left, PositionSetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}