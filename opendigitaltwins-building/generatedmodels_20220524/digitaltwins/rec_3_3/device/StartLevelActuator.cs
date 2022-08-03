using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class StartLevelActuator : LevelActuator, IEquatable<StartLevelActuator>
    {
        public StartLevelActuator()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:StartLevelActuator;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as StartLevelActuator);
        }

        public bool Equals(StartLevelActuator? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(StartLevelActuator? left, StartLevelActuator? right)
        {
            return EqualityComparer<StartLevelActuator?>.Default.Equals(left, right);
        }

        public static bool operator !=(StartLevelActuator? left, StartLevelActuator? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}