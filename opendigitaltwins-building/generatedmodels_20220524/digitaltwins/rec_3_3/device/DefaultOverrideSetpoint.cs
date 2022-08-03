using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class DefaultOverrideSetpoint : BinarySetpoint, IEquatable<DefaultOverrideSetpoint>
    {
        public DefaultOverrideSetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:DefaultOverrideSetpoint;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as DefaultOverrideSetpoint);
        }

        public bool Equals(DefaultOverrideSetpoint? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(DefaultOverrideSetpoint? left, DefaultOverrideSetpoint? right)
        {
            return EqualityComparer<DefaultOverrideSetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(DefaultOverrideSetpoint? left, DefaultOverrideSetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}