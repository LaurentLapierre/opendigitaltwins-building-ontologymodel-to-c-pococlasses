using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class StopActuator : StartStopActuator, IEquatable<StopActuator>
    {
        public StopActuator()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:StopActuator;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as StopActuator);
        }

        public bool Equals(StopActuator? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(StopActuator? left, StopActuator? right)
        {
            return EqualityComparer<StopActuator?>.Default.Equals(left, right);
        }

        public static bool operator !=(StopActuator? left, StopActuator? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}