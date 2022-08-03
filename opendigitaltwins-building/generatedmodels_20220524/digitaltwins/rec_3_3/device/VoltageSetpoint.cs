using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class VoltageSetpoint : QuantitySetpoint, IEquatable<VoltageSetpoint>
    {
        public VoltageSetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:VoltageSetpoint;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as VoltageSetpoint);
        }

        public bool Equals(VoltageSetpoint? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(VoltageSetpoint? left, VoltageSetpoint? right)
        {
            return EqualityComparer<VoltageSetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(VoltageSetpoint? left, VoltageSetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}