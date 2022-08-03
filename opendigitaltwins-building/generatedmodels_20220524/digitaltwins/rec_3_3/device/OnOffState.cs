using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class OnOffState : BinaryState, IEquatable<OnOffState>
    {
        public OnOffState()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:OnOffState;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as OnOffState);
        }

        public bool Equals(OnOffState? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(OnOffState? left, OnOffState? right)
        {
            return EqualityComparer<OnOffState?>.Default.Equals(left, right);
        }

        public static bool operator !=(OnOffState? left, OnOffState? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}