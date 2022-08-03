using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class DewPointTemperatureSetpoint : TemperatureSetpoint, IEquatable<DewPointTemperatureSetpoint>
    {
        public DewPointTemperatureSetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:DewPointTemperatureSetpoint;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as DewPointTemperatureSetpoint);
        }

        public bool Equals(DewPointTemperatureSetpoint? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(DewPointTemperatureSetpoint? left, DewPointTemperatureSetpoint? right)
        {
            return EqualityComparer<DewPointTemperatureSetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(DewPointTemperatureSetpoint? left, DewPointTemperatureSetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}