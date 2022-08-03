using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class MultiStateSetpoint : StateSetpoint, IEquatable<MultiStateSetpoint>
    {
        public MultiStateSetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:MultiStateSetpoint;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as MultiStateSetpoint);
        }

        public bool Equals(MultiStateSetpoint? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(MultiStateSetpoint? left, MultiStateSetpoint? right)
        {
            return EqualityComparer<MultiStateSetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(MultiStateSetpoint? left, MultiStateSetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}