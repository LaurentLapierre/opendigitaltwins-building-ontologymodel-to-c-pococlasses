using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class FireDetectionEquipment : FireProtectionEquipment, IEquatable<FireDetectionEquipment>
    {
        public FireDetectionEquipment()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:FireDetectionEquipment;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as FireDetectionEquipment);
        }

        public bool Equals(FireDetectionEquipment? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(FireDetectionEquipment? left, FireDetectionEquipment? right)
        {
            return EqualityComparer<FireDetectionEquipment?>.Default.Equals(left, right);
        }

        public static bool operator !=(FireDetectionEquipment? left, FireDetectionEquipment? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}