using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class CurrentSensor : QuantitySensor, IEquatable<CurrentSensor>
    {
        public CurrentSensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:CurrentSensor;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as CurrentSensor);
        }

        public bool Equals(CurrentSensor? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(CurrentSensor? left, CurrentSensor? right)
        {
            return EqualityComparer<CurrentSensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(CurrentSensor? left, CurrentSensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}