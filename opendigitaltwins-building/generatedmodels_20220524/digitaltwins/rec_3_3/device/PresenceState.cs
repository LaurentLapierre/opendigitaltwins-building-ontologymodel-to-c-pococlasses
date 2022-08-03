using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class PresenceState : PresenceAbsenceState, IEquatable<PresenceState>
    {
        public PresenceState()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:PresenceState;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as PresenceState);
        }

        public bool Equals(PresenceState? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(PresenceState? left, PresenceState? right)
        {
            return EqualityComparer<PresenceState?>.Default.Equals(left, right);
        }

        public static bool operator !=(PresenceState? left, PresenceState? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}