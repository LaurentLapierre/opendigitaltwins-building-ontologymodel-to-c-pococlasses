using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class LevelSensor : PercentSensor, IEquatable<LevelSensor>
    {
        public LevelSensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:LevelSensor;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as LevelSensor);
        }

        public bool Equals(LevelSensor? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(LevelSensor? left, LevelSensor? right)
        {
            return EqualityComparer<LevelSensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(LevelSensor? left, LevelSensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}