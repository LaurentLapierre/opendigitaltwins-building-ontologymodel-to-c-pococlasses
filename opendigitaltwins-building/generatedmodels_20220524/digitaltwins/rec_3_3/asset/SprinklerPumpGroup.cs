using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class SprinklerPumpGroup : FireProtectionEquipmentGroup, IEquatable<SprinklerPumpGroup>
    {
        public SprinklerPumpGroup()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:SprinklerPumpGroup;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as SprinklerPumpGroup);
        }

        public bool Equals(SprinklerPumpGroup? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(SprinklerPumpGroup? left, SprinklerPumpGroup? right)
        {
            return EqualityComparer<SprinklerPumpGroup?>.Default.Equals(left, right);
        }

        public static bool operator !=(SprinklerPumpGroup? left, SprinklerPumpGroup? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}