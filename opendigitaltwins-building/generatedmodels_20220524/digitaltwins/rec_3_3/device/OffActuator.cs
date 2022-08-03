using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class OffActuator : OnOffActuator, IEquatable<OffActuator>
    {
        public OffActuator()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:OffActuator;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as OffActuator);
        }

        public bool Equals(OffActuator? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(OffActuator? left, OffActuator? right)
        {
            return EqualityComparer<OffActuator?>.Default.Equals(left, right);
        }

        public static bool operator !=(OffActuator? left, OffActuator? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}