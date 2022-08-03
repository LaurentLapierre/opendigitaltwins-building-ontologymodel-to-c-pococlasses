using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class DefaultSensor : DefaultOverrideSensor, IEquatable<DefaultSensor>
    {
        public DefaultSensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:DefaultSensor;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as DefaultSensor);
        }

        public bool Equals(DefaultSensor? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(DefaultSensor? left, DefaultSensor? right)
        {
            return EqualityComparer<DefaultSensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(DefaultSensor? left, DefaultSensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}