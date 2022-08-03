using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class TotalPressureSetpoint : PressureSetpoint, IEquatable<TotalPressureSetpoint>
    {
        public TotalPressureSetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:TotalPressureSetpoint;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as TotalPressureSetpoint);
        }

        public bool Equals(TotalPressureSetpoint? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(TotalPressureSetpoint? left, TotalPressureSetpoint? right)
        {
            return EqualityComparer<TotalPressureSetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(TotalPressureSetpoint? left, TotalPressureSetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}