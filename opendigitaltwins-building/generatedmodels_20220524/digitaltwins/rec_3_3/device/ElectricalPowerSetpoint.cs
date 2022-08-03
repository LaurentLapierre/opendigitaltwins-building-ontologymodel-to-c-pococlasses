using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class ElectricalPowerSetpoint : PowerSetpoint, IEquatable<ElectricalPowerSetpoint>
    {
        public ElectricalPowerSetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:ElectricalPowerSetpoint;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as ElectricalPowerSetpoint);
        }

        public bool Equals(ElectricalPowerSetpoint? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(ElectricalPowerSetpoint? left, ElectricalPowerSetpoint? right)
        {
            return EqualityComparer<ElectricalPowerSetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(ElectricalPowerSetpoint? left, ElectricalPowerSetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}