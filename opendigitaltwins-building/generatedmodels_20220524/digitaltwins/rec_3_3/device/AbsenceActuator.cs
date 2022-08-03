using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class AbsenceActuator : PresenceAbsenceActuator, IEquatable<AbsenceActuator>
    {
        public AbsenceActuator()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:AbsenceActuator;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as AbsenceActuator);
        }

        public bool Equals(AbsenceActuator? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(AbsenceActuator? left, AbsenceActuator? right)
        {
            return EqualityComparer<AbsenceActuator?>.Default.Equals(left, right);
        }

        public static bool operator !=(AbsenceActuator? left, AbsenceActuator? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}