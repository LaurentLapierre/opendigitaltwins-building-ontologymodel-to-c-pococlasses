using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class CloseSetpoint : OpenCloseSetpoint, IEquatable<CloseSetpoint>
    {
        public CloseSetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:CloseSetpoint;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as CloseSetpoint);
        }

        public bool Equals(CloseSetpoint? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(CloseSetpoint? left, CloseSetpoint? right)
        {
            return EqualityComparer<CloseSetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(CloseSetpoint? left, CloseSetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}