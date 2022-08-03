using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class ResetSetpoint : DefaultSetpoint, IEquatable<ResetSetpoint>
    {
        public ResetSetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:ResetSetpoint;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as ResetSetpoint);
        }

        public bool Equals(ResetSetpoint? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(ResetSetpoint? left, ResetSetpoint? right)
        {
            return EqualityComparer<ResetSetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(ResetSetpoint? left, ResetSetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}