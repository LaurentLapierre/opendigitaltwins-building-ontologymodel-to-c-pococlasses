using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class AbsenceSensor : PresenceAbsenceSensor, IEquatable<AbsenceSensor>
    {
        public AbsenceSensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:AbsenceSensor;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as AbsenceSensor);
        }

        public bool Equals(AbsenceSensor? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(AbsenceSensor? left, AbsenceSensor? right)
        {
            return EqualityComparer<AbsenceSensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(AbsenceSensor? left, AbsenceSensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}