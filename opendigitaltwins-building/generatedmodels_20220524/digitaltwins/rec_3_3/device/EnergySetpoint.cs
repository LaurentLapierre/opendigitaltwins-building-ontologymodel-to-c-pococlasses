using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class EnergySetpoint : QuantitySetpoint, IEquatable<EnergySetpoint>
    {
        public EnergySetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:EnergySetpoint;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as EnergySetpoint);
        }

        public bool Equals(EnergySetpoint? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(EnergySetpoint? left, EnergySetpoint? right)
        {
            return EqualityComparer<EnergySetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(EnergySetpoint? left, EnergySetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}