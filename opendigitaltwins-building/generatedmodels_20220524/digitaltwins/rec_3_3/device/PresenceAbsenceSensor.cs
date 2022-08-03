using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class PresenceAbsenceSensor : BinarySensor, IEquatable<PresenceAbsenceSensor>
    {
        public PresenceAbsenceSensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:PresenceAbsenceSensor;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as PresenceAbsenceSensor);
        }

        public bool Equals(PresenceAbsenceSensor? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(PresenceAbsenceSensor? left, PresenceAbsenceSensor? right)
        {
            return EqualityComparer<PresenceAbsenceSensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(PresenceAbsenceSensor? left, PresenceAbsenceSensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}