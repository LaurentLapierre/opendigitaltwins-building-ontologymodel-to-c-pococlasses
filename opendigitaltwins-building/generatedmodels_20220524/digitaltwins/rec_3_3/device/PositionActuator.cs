using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class PositionActuator : PercentActuator, IEquatable<PositionActuator>
    {
        public PositionActuator()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:PositionActuator;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as PositionActuator);
        }

        public bool Equals(PositionActuator? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(PositionActuator? left, PositionActuator? right)
        {
            return EqualityComparer<PositionActuator?>.Default.Equals(left, right);
        }

        public static bool operator !=(PositionActuator? left, PositionActuator? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}