using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class OnLevelSetpoint : LevelSetpoint, IEquatable<OnLevelSetpoint>
    {
        public OnLevelSetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:OnLevelSetpoint;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as OnLevelSetpoint);
        }

        public bool Equals(OnLevelSetpoint? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(OnLevelSetpoint? left, OnLevelSetpoint? right)
        {
            return EqualityComparer<OnLevelSetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(OnLevelSetpoint? left, OnLevelSetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}