using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class PresenceSensor : PresenceAbsenceSensor, IEquatable<PresenceSensor>
    {
        public PresenceSensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:PresenceSensor;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as PresenceSensor);
        }

        public bool Equals(PresenceSensor? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(PresenceSensor? left, PresenceSensor? right)
        {
            return EqualityComparer<PresenceSensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(PresenceSensor? left, PresenceSensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}