using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class FireSensor : BinarySensor, IEquatable<FireSensor>
    {
        public FireSensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:FireSensor;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as FireSensor);
        }

        public bool Equals(FireSensor? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(FireSensor? left, FireSensor? right)
        {
            return EqualityComparer<FireSensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(FireSensor? left, FireSensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}