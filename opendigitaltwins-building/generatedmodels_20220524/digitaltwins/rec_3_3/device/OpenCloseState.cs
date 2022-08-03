using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class OpenCloseState : BinaryState, IEquatable<OpenCloseState>
    {
        public OpenCloseState()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:OpenCloseState;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as OpenCloseState);
        }

        public bool Equals(OpenCloseState? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(OpenCloseState? left, OpenCloseState? right)
        {
            return EqualityComparer<OpenCloseState?>.Default.Equals(left, right);
        }

        public static bool operator !=(OpenCloseState? left, OpenCloseState? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}