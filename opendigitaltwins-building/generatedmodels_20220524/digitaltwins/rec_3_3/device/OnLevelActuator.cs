using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class OnLevelActuator : LevelActuator, IEquatable<OnLevelActuator>
    {
        public OnLevelActuator()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:OnLevelActuator;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as OnLevelActuator);
        }

        public bool Equals(OnLevelActuator? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(OnLevelActuator? left, OnLevelActuator? right)
        {
            return EqualityComparer<OnLevelActuator?>.Default.Equals(left, right);
        }

        public static bool operator !=(OnLevelActuator? left, OnLevelActuator? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}