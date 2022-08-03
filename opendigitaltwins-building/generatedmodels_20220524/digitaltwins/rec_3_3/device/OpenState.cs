using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class OpenState : OpenCloseState, IEquatable<OpenState>
    {
        public OpenState()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:OpenState;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as OpenState);
        }

        public bool Equals(OpenState? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(OpenState? left, OpenState? right)
        {
            return EqualityComparer<OpenState?>.Default.Equals(left, right);
        }

        public static bool operator !=(OpenState? left, OpenState? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}