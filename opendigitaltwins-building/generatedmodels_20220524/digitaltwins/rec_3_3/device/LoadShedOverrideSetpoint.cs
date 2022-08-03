using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class LoadShedOverrideSetpoint : OverrideSetpoint, IEquatable<LoadShedOverrideSetpoint>
    {
        public LoadShedOverrideSetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:LoadShedOverrideSetpoint;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as LoadShedOverrideSetpoint);
        }

        public bool Equals(LoadShedOverrideSetpoint? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(LoadShedOverrideSetpoint? left, LoadShedOverrideSetpoint? right)
        {
            return EqualityComparer<LoadShedOverrideSetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(LoadShedOverrideSetpoint? left, LoadShedOverrideSetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}