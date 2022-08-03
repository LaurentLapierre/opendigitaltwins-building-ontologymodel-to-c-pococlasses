using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class MotionSensor : BinarySensor, IEquatable<MotionSensor>
    {
        public MotionSensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:MotionSensor;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as MotionSensor);
        }

        public bool Equals(MotionSensor? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(MotionSensor? left, MotionSensor? right)
        {
            return EqualityComparer<MotionSensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(MotionSensor? left, MotionSensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}