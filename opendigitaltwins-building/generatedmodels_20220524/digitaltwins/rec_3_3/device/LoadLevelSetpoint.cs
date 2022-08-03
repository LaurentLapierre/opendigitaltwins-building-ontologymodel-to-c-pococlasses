using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class LoadLevelSetpoint : LevelSetpoint, IEquatable<LoadLevelSetpoint>
    {
        public LoadLevelSetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:LoadLevelSetpoint;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as LoadLevelSetpoint);
        }

        public bool Equals(LoadLevelSetpoint? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(LoadLevelSetpoint? left, LoadLevelSetpoint? right)
        {
            return EqualityComparer<LoadLevelSetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(LoadLevelSetpoint? left, LoadLevelSetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}