using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class CloseState : OpenCloseState, IEquatable<CloseState>
    {
        public CloseState()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:CloseState;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as CloseState);
        }

        public bool Equals(CloseState? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(CloseState? left, CloseState? right)
        {
            return EqualityComparer<CloseState?>.Default.Equals(left, right);
        }

        public static bool operator !=(CloseState? left, CloseState? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}