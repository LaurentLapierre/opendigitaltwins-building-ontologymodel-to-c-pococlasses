using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class PresenceAbsenceActuator : BinaryActuator, IEquatable<PresenceAbsenceActuator>
    {
        public PresenceAbsenceActuator()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:PresenceAbsenceActuator;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as PresenceAbsenceActuator);
        }

        public bool Equals(PresenceAbsenceActuator? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(PresenceAbsenceActuator? left, PresenceAbsenceActuator? right)
        {
            return EqualityComparer<PresenceAbsenceActuator?>.Default.Equals(left, right);
        }

        public static bool operator !=(PresenceAbsenceActuator? left, PresenceAbsenceActuator? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}