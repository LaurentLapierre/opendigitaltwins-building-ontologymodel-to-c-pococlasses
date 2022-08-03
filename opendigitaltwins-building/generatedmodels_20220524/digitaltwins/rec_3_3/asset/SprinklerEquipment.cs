using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class SprinklerEquipment : FireSuppressionEquipment, IEquatable<SprinklerEquipment>
    {
        public SprinklerEquipment()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:SprinklerEquipment;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as SprinklerEquipment);
        }

        public bool Equals(SprinklerEquipment? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(SprinklerEquipment? left, SprinklerEquipment? right)
        {
            return EqualityComparer<SprinklerEquipment?>.Default.Equals(left, right);
        }

        public static bool operator !=(SprinklerEquipment? left, SprinklerEquipment? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}