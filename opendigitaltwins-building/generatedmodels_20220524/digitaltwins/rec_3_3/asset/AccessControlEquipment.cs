using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class AccessControlEquipment : SecurityEquipment, IEquatable<AccessControlEquipment>
    {
        public AccessControlEquipment()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:AccessControlEquipment;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as AccessControlEquipment);
        }

        public bool Equals(AccessControlEquipment? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(AccessControlEquipment? left, AccessControlEquipment? right)
        {
            return EqualityComparer<AccessControlEquipment?>.Default.Equals(left, right);
        }

        public static bool operator !=(AccessControlEquipment? left, AccessControlEquipment? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}