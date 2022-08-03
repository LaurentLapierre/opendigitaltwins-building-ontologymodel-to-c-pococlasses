using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class HVACPumpGroup : HVACEquipmentGroup, IEquatable<HVACPumpGroup>
    {
        public HVACPumpGroup()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:HVACPumpGroup;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as HVACPumpGroup);
        }

        public bool Equals(HVACPumpGroup? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(HVACPumpGroup? left, HVACPumpGroup? right)
        {
            return EqualityComparer<HVACPumpGroup?>.Default.Equals(left, right);
        }

        public static bool operator !=(HVACPumpGroup? left, HVACPumpGroup? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}