using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class AbsenceState : PresenceAbsenceState, IEquatable<AbsenceState>
    {
        public AbsenceState()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:AbsenceState;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as AbsenceState);
        }

        public bool Equals(AbsenceState? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(AbsenceState? left, AbsenceState? right)
        {
            return EqualityComparer<AbsenceState?>.Default.Equals(left, right);
        }

        public static bool operator !=(AbsenceState? left, AbsenceState? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}