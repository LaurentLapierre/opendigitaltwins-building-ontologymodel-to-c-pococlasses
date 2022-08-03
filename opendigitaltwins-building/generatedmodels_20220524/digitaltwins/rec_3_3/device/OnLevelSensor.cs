using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class OnLevelSensor : LevelSensor, IEquatable<OnLevelSensor>
    {
        public OnLevelSensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:OnLevelSensor;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as OnLevelSensor);
        }

        public bool Equals(OnLevelSensor? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(OnLevelSensor? left, OnLevelSensor? right)
        {
            return EqualityComparer<OnLevelSensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(OnLevelSensor? left, OnLevelSensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}