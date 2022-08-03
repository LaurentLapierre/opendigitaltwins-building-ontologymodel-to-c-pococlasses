using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class ElectricalDistributionEquipment : ElectricalEquipment, IEquatable<ElectricalDistributionEquipment>
    {
        public ElectricalDistributionEquipment()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:ElectricalDistributionEquipment;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as ElectricalDistributionEquipment);
        }

        public bool Equals(ElectricalDistributionEquipment? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(ElectricalDistributionEquipment? left, ElectricalDistributionEquipment? right)
        {
            return EqualityComparer<ElectricalDistributionEquipment?>.Default.Equals(left, right);
        }

        public static bool operator !=(ElectricalDistributionEquipment? left, ElectricalDistributionEquipment? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}