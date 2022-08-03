using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class ModeSetpoint : MultiStateSetpoint, IEquatable<ModeSetpoint>
    {
        public ModeSetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:ModeSetpoint;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as ModeSetpoint);
        }

        public bool Equals(ModeSetpoint? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(ModeSetpoint? left, ModeSetpoint? right)
        {
            return EqualityComparer<ModeSetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(ModeSetpoint? left, ModeSetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}