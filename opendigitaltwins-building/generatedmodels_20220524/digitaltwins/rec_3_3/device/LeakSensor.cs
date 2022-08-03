using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class LeakSensor : BinarySensor, IEquatable<LeakSensor>
    {
        public LeakSensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:LeakSensor;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as LeakSensor);
        }

        public bool Equals(LeakSensor? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(LeakSensor? left, LeakSensor? right)
        {
            return EqualityComparer<LeakSensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(LeakSensor? left, LeakSensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}