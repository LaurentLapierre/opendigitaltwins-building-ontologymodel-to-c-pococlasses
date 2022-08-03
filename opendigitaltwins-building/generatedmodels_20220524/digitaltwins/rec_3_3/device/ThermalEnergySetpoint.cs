using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class ThermalEnergySetpoint : EnergySetpoint, IEquatable<ThermalEnergySetpoint>
    {
        public ThermalEnergySetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:ThermalEnergySetpoint;1";
        [JsonPropertyName("lastValue")]
        public double? LastValue { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as ThermalEnergySetpoint);
        }

        public bool Equals(ThermalEnergySetpoint? other)
        {
            return other is not null && base.Equals(other) && LastValue == other.LastValue;
        }

        public static bool operator ==(ThermalEnergySetpoint? left, ThermalEnergySetpoint? right)
        {
            return EqualityComparer<ThermalEnergySetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(ThermalEnergySetpoint? left, ThermalEnergySetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), LastValue?.GetHashCode());
        }
    }
}