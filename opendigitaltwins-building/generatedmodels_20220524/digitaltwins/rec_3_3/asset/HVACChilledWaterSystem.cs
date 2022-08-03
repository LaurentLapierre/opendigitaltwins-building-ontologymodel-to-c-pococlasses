using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class HVACChilledWaterSystem : HVACWaterSystem, IEquatable<HVACChilledWaterSystem>
    {
        public HVACChilledWaterSystem()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:HVACChilledWaterSystem;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as HVACChilledWaterSystem);
        }

        public bool Equals(HVACChilledWaterSystem? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(HVACChilledWaterSystem? left, HVACChilledWaterSystem? right)
        {
            return EqualityComparer<HVACChilledWaterSystem?>.Default.Equals(left, right);
        }

        public static bool operator !=(HVACChilledWaterSystem? left, HVACChilledWaterSystem? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}