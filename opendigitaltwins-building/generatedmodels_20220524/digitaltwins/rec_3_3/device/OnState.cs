using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class OnState : OnOffState, IEquatable<OnState>
    {
        public OnState()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:OnState;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as OnState);
        }

        public bool Equals(OnState? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(OnState? left, OnState? right)
        {
            return EqualityComparer<OnState?>.Default.Equals(left, right);
        }

        public static bool operator !=(OnState? left, OnState? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}