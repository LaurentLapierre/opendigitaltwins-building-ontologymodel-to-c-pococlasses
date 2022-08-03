using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class ElectricalEquipment : Equipment, IEquatable<ElectricalEquipment>
    {
        public ElectricalEquipment()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:ElectricalEquipment;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as ElectricalEquipment);
        }

        public bool Equals(ElectricalEquipment? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(ElectricalEquipment? left, ElectricalEquipment? right)
        {
            return EqualityComparer<ElectricalEquipment?>.Default.Equals(left, right);
        }

        public static bool operator !=(ElectricalEquipment? left, ElectricalEquipment? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}