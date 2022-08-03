using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class PresenceActuator : PresenceAbsenceActuator, IEquatable<PresenceActuator>
    {
        public PresenceActuator()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:PresenceActuator;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as PresenceActuator);
        }

        public bool Equals(PresenceActuator? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(PresenceActuator? left, PresenceActuator? right)
        {
            return EqualityComparer<PresenceActuator?>.Default.Equals(left, right);
        }

        public static bool operator !=(PresenceActuator? left, PresenceActuator? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}