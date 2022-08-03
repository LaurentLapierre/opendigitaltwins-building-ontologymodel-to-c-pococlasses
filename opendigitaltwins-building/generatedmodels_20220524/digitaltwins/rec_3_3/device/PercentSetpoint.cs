using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class PercentSetpoint : StateSetpoint, IEquatable<PercentSetpoint>
    {
        public PercentSetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:PercentSetpoint;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as PercentSetpoint);
        }

        public bool Equals(PercentSetpoint? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(PercentSetpoint? left, PercentSetpoint? right)
        {
            return EqualityComparer<PercentSetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(PercentSetpoint? left, PercentSetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}