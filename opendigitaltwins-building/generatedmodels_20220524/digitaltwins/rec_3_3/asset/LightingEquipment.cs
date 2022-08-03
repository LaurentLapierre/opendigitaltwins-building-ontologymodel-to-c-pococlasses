using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class LightingEquipment : Equipment, IEquatable<LightingEquipment>
    {
        public LightingEquipment()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:LightingEquipment;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as LightingEquipment);
        }

        public bool Equals(LightingEquipment? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(LightingEquipment? left, LightingEquipment? right)
        {
            return EqualityComparer<LightingEquipment?>.Default.Equals(left, right);
        }

        public static bool operator !=(LightingEquipment? left, LightingEquipment? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}