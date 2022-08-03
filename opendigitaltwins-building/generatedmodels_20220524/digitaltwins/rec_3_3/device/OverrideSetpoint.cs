using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class OverrideSetpoint : DefaultOverrideSetpoint, IEquatable<OverrideSetpoint>
    {
        public OverrideSetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:OverrideSetpoint;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as OverrideSetpoint);
        }

        public bool Equals(OverrideSetpoint? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(OverrideSetpoint? left, OverrideSetpoint? right)
        {
            return EqualityComparer<OverrideSetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(OverrideSetpoint? left, OverrideSetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}