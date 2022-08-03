using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class AbsenceSetpoint : PresenceAbsenceSetpoint, IEquatable<AbsenceSetpoint>
    {
        public AbsenceSetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:AbsenceSetpoint;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as AbsenceSetpoint);
        }

        public bool Equals(AbsenceSetpoint? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(AbsenceSetpoint? left, AbsenceSetpoint? right)
        {
            return EqualityComparer<AbsenceSetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(AbsenceSetpoint? left, AbsenceSetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}