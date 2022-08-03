using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class ApparentElectricalEnergySetpoint : ElectricalEnergySetpoint, IEquatable<ApparentElectricalEnergySetpoint>
    {
        public ApparentElectricalEnergySetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:ApparentElectricalEnergySetpoint;1";
        [JsonPropertyName("lastValue")]
        public double? LastValue { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as ApparentElectricalEnergySetpoint);
        }

        public bool Equals(ApparentElectricalEnergySetpoint? other)
        {
            return other is not null && base.Equals(other) && LastValue == other.LastValue;
        }

        public static bool operator ==(ApparentElectricalEnergySetpoint? left, ApparentElectricalEnergySetpoint? right)
        {
            return EqualityComparer<ApparentElectricalEnergySetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(ApparentElectricalEnergySetpoint? left, ApparentElectricalEnergySetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), LastValue?.GetHashCode());
        }
    }
}