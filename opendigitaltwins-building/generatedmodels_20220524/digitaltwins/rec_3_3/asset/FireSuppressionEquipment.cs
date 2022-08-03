using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class FireSuppressionEquipment : FireProtectionEquipment, IEquatable<FireSuppressionEquipment>
    {
        public FireSuppressionEquipment()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:FireSuppressionEquipment;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as FireSuppressionEquipment);
        }

        public bool Equals(FireSuppressionEquipment? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(FireSuppressionEquipment? left, FireSuppressionEquipment? right)
        {
            return EqualityComparer<FireSuppressionEquipment?>.Default.Equals(left, right);
        }

        public static bool operator !=(FireSuppressionEquipment? left, FireSuppressionEquipment? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}