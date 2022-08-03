using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class DefaultActuator : DefaultOverrideActuator, IEquatable<DefaultActuator>
    {
        public DefaultActuator()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:DefaultActuator;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as DefaultActuator);
        }

        public bool Equals(DefaultActuator? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(DefaultActuator? left, DefaultActuator? right)
        {
            return EqualityComparer<DefaultActuator?>.Default.Equals(left, right);
        }

        public static bool operator !=(DefaultActuator? left, DefaultActuator? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}