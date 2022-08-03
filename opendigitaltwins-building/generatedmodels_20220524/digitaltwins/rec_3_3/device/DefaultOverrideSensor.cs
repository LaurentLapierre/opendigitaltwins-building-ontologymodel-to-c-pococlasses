using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class DefaultOverrideSensor : BinarySensor, IEquatable<DefaultOverrideSensor>
    {
        public DefaultOverrideSensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:DefaultOverrideSensor;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as DefaultOverrideSensor);
        }

        public bool Equals(DefaultOverrideSensor? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(DefaultOverrideSensor? left, DefaultOverrideSensor? right)
        {
            return EqualityComparer<DefaultOverrideSensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(DefaultOverrideSensor? left, DefaultOverrideSensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}