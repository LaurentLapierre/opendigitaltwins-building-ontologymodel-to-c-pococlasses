using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class StartLevelSetpoint : LevelSetpoint, IEquatable<StartLevelSetpoint>
    {
        public StartLevelSetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:StartLevelSetpoint;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as StartLevelSetpoint);
        }

        public bool Equals(StartLevelSetpoint? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(StartLevelSetpoint? left, StartLevelSetpoint? right)
        {
            return EqualityComparer<StartLevelSetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(StartLevelSetpoint? left, StartLevelSetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}