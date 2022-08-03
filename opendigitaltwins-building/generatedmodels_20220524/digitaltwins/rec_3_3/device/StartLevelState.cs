using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class StartLevelState : LevelState, IEquatable<StartLevelState>
    {
        public StartLevelState()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:StartLevelState;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as StartLevelState);
        }

        public bool Equals(StartLevelState? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(StartLevelState? left, StartLevelState? right)
        {
            return EqualityComparer<StartLevelState?>.Default.Equals(left, right);
        }

        public static bool operator !=(StartLevelState? left, StartLevelState? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}