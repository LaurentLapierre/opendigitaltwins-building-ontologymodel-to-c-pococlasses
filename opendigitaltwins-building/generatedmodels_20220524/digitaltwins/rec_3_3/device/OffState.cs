using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class OffState : OnOffState, IEquatable<OffState>
    {
        public OffState()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:OffState;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as OffState);
        }

        public bool Equals(OffState? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(OffState? left, OffState? right)
        {
            return EqualityComparer<OffState?>.Default.Equals(left, right);
        }

        public static bool operator !=(OffState? left, OffState? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}