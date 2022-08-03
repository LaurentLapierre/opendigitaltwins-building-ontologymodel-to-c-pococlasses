using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class VelocityPressureSetpoint : PressureSetpoint, IEquatable<VelocityPressureSetpoint>
    {
        public VelocityPressureSetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:VelocityPressureSetpoint;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as VelocityPressureSetpoint);
        }

        public bool Equals(VelocityPressureSetpoint? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(VelocityPressureSetpoint? left, VelocityPressureSetpoint? right)
        {
            return EqualityComparer<VelocityPressureSetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(VelocityPressureSetpoint? left, VelocityPressureSetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}