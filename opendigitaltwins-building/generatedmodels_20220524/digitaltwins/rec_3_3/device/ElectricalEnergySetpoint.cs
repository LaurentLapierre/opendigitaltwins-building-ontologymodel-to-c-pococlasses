using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class ElectricalEnergySetpoint : EnergySetpoint, IEquatable<ElectricalEnergySetpoint>
    {
        public ElectricalEnergySetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:ElectricalEnergySetpoint;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as ElectricalEnergySetpoint);
        }

        public bool Equals(ElectricalEnergySetpoint? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(ElectricalEnergySetpoint? left, ElectricalEnergySetpoint? right)
        {
            return EqualityComparer<ElectricalEnergySetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(ElectricalEnergySetpoint? left, ElectricalEnergySetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}