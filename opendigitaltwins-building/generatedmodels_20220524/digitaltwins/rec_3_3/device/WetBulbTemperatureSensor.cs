using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class WetBulbTemperatureSensor : TemperatureSensor, IEquatable<WetBulbTemperatureSensor>
    {
        public WetBulbTemperatureSensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:WetBulbTemperatureSensor;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as WetBulbTemperatureSensor);
        }

        public bool Equals(WetBulbTemperatureSensor? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(WetBulbTemperatureSensor? left, WetBulbTemperatureSensor? right)
        {
            return EqualityComparer<WetBulbTemperatureSensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(WetBulbTemperatureSensor? left, WetBulbTemperatureSensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}