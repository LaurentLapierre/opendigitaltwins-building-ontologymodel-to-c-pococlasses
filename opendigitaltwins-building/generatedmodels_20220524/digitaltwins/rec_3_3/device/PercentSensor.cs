using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class PercentSensor : StateSensor, IEquatable<PercentSensor>
    {
        public PercentSensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:PercentSensor;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as PercentSensor);
        }

        public bool Equals(PercentSensor? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(PercentSensor? left, PercentSensor? right)
        {
            return EqualityComparer<PercentSensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(PercentSensor? left, PercentSensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}