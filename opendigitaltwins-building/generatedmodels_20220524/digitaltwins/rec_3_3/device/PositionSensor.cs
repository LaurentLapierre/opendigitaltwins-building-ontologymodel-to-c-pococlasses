using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class PositionSensor : PercentSensor, IEquatable<PositionSensor>
    {
        public PositionSensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:PositionSensor;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as PositionSensor);
        }

        public bool Equals(PositionSensor? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(PositionSensor? left, PositionSensor? right)
        {
            return EqualityComparer<PositionSensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(PositionSensor? left, PositionSensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}