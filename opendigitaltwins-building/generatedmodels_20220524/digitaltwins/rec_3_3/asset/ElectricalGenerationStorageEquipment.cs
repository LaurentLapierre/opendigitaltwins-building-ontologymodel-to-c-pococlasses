using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class ElectricalGenerationStorageEquipment : ElectricalEquipment, IEquatable<ElectricalGenerationStorageEquipment>
    {
        public ElectricalGenerationStorageEquipment()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:ElectricalGenerationStorageEquipment;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as ElectricalGenerationStorageEquipment);
        }

        public bool Equals(ElectricalGenerationStorageEquipment? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(ElectricalGenerationStorageEquipment? left, ElectricalGenerationStorageEquipment? right)
        {
            return EqualityComparer<ElectricalGenerationStorageEquipment?>.Default.Equals(left, right);
        }

        public static bool operator !=(ElectricalGenerationStorageEquipment? left, ElectricalGenerationStorageEquipment? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}