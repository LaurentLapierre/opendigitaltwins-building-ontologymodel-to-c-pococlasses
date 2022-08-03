using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class DefaultSetpoint : DefaultOverrideSetpoint, IEquatable<DefaultSetpoint>
    {
        public DefaultSetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:DefaultSetpoint;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as DefaultSetpoint);
        }

        public bool Equals(DefaultSetpoint? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(DefaultSetpoint? left, DefaultSetpoint? right)
        {
            return EqualityComparer<DefaultSetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(DefaultSetpoint? left, DefaultSetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}