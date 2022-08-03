using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class HVACWaterTreatment : HVACEquipment, IEquatable<HVACWaterTreatment>
    {
        public HVACWaterTreatment()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:HVACWaterTreatment;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as HVACWaterTreatment);
        }

        public bool Equals(HVACWaterTreatment? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(HVACWaterTreatment? left, HVACWaterTreatment? right)
        {
            return EqualityComparer<HVACWaterTreatment?>.Default.Equals(left, right);
        }

        public static bool operator !=(HVACWaterTreatment? left, HVACWaterTreatment? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}