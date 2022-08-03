using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class SecurityEquipment : Equipment, IEquatable<SecurityEquipment>
    {
        public SecurityEquipment()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:SecurityEquipment;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as SecurityEquipment);
        }

        public bool Equals(SecurityEquipment? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(SecurityEquipment? left, SecurityEquipment? right)
        {
            return EqualityComparer<SecurityEquipment?>.Default.Equals(left, right);
        }

        public static bool operator !=(SecurityEquipment? left, SecurityEquipment? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}