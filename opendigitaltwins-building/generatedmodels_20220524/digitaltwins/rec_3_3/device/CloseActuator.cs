using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class CloseActuator : OpenCloseActuator, IEquatable<CloseActuator>
    {
        public CloseActuator()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:CloseActuator;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as CloseActuator);
        }

        public bool Equals(CloseActuator? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(CloseActuator? left, CloseActuator? right)
        {
            return EqualityComparer<CloseActuator?>.Default.Equals(left, right);
        }

        public static bool operator !=(CloseActuator? left, CloseActuator? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}