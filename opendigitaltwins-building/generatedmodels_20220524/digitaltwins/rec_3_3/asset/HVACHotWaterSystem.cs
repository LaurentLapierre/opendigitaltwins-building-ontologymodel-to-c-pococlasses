using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class HVACHotWaterSystem : HVACWaterSystem, IEquatable<HVACHotWaterSystem>
    {
        public HVACHotWaterSystem()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:HVACHotWaterSystem;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as HVACHotWaterSystem);
        }

        public bool Equals(HVACHotWaterSystem? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(HVACHotWaterSystem? left, HVACHotWaterSystem? right)
        {
            return EqualityComparer<HVACHotWaterSystem?>.Default.Equals(left, right);
        }

        public static bool operator !=(HVACHotWaterSystem? left, HVACHotWaterSystem? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}