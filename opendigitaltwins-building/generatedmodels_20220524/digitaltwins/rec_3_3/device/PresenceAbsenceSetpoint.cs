using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class PresenceAbsenceSetpoint : BinarySetpoint, IEquatable<PresenceAbsenceSetpoint>
    {
        public PresenceAbsenceSetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:PresenceAbsenceSetpoint;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as PresenceAbsenceSetpoint);
        }

        public bool Equals(PresenceAbsenceSetpoint? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(PresenceAbsenceSetpoint? left, PresenceAbsenceSetpoint? right)
        {
            return EqualityComparer<PresenceAbsenceSetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(PresenceAbsenceSetpoint? left, PresenceAbsenceSetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}