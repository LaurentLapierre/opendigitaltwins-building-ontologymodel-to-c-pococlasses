using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class PresenceSetpoint : PresenceAbsenceSetpoint, IEquatable<PresenceSetpoint>
    {
        public PresenceSetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:PresenceSetpoint;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as PresenceSetpoint);
        }

        public bool Equals(PresenceSetpoint? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(PresenceSetpoint? left, PresenceSetpoint? right)
        {
            return EqualityComparer<PresenceSetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(PresenceSetpoint? left, PresenceSetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}