using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class StartStopActuator : BinaryActuator, IEquatable<StartStopActuator>
    {
        public StartStopActuator()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:StartStopActuator;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as StartStopActuator);
        }

        public bool Equals(StartStopActuator? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(StartStopActuator? left, StartStopActuator? right)
        {
            return EqualityComparer<StartStopActuator?>.Default.Equals(left, right);
        }

        public static bool operator !=(StartStopActuator? left, StartStopActuator? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}