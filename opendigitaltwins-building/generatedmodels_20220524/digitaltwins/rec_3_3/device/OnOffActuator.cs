using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class OnOffActuator : BinaryActuator, IEquatable<OnOffActuator>
    {
        public OnOffActuator()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:OnOffActuator;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as OnOffActuator);
        }

        public bool Equals(OnOffActuator? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(OnOffActuator? left, OnOffActuator? right)
        {
            return EqualityComparer<OnOffActuator?>.Default.Equals(left, right);
        }

        public static bool operator !=(OnOffActuator? left, OnOffActuator? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}