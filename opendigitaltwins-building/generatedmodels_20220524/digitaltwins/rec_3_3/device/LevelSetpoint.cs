using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class LevelSetpoint : PercentSetpoint, IEquatable<LevelSetpoint>
    {
        public LevelSetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:LevelSetpoint;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as LevelSetpoint);
        }

        public bool Equals(LevelSetpoint? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(LevelSetpoint? left, LevelSetpoint? right)
        {
            return EqualityComparer<LevelSetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(LevelSetpoint? left, LevelSetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}