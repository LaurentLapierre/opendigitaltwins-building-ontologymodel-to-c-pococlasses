using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class PresenceAbsenceState : BinaryState, IEquatable<PresenceAbsenceState>
    {
        public PresenceAbsenceState()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:PresenceAbsenceState;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as PresenceAbsenceState);
        }

        public bool Equals(PresenceAbsenceState? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(PresenceAbsenceState? left, PresenceAbsenceState? right)
        {
            return EqualityComparer<PresenceAbsenceState?>.Default.Equals(left, right);
        }

        public static bool operator !=(PresenceAbsenceState? left, PresenceAbsenceState? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}