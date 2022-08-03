using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class LevelActuator : PercentActuator, IEquatable<LevelActuator>
    {
        public LevelActuator()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:LevelActuator;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as LevelActuator);
        }

        public bool Equals(LevelActuator? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(LevelActuator? left, LevelActuator? right)
        {
            return EqualityComparer<LevelActuator?>.Default.Equals(left, right);
        }

        public static bool operator !=(LevelActuator? left, LevelActuator? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}