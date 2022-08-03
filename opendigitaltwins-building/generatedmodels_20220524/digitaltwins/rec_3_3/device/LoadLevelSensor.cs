using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class LoadLevelSensor : LevelSensor, IEquatable<LoadLevelSensor>
    {
        public LoadLevelSensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:LoadLevelSensor;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as LoadLevelSensor);
        }

        public bool Equals(LoadLevelSensor? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(LoadLevelSensor? left, LoadLevelSensor? right)
        {
            return EqualityComparer<LoadLevelSensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(LoadLevelSensor? left, LoadLevelSensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}