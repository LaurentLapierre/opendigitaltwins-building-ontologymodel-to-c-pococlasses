using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class LoadLevelState : LevelState, IEquatable<LoadLevelState>
    {
        public LoadLevelState()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:LoadLevelState;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as LoadLevelState);
        }

        public bool Equals(LoadLevelState? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(LoadLevelState? left, LoadLevelState? right)
        {
            return EqualityComparer<LoadLevelState?>.Default.Equals(left, right);
        }

        public static bool operator !=(LoadLevelState? left, LoadLevelState? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}