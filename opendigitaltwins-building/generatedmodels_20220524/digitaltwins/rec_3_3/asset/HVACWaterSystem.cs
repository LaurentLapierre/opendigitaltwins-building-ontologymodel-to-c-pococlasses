using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class HVACWaterSystem : HVACSystem, IEquatable<HVACWaterSystem>
    {
        public HVACWaterSystem()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:HVACWaterSystem;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as HVACWaterSystem);
        }

        public bool Equals(HVACWaterSystem? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(HVACWaterSystem? left, HVACWaterSystem? right)
        {
            return EqualityComparer<HVACWaterSystem?>.Default.Equals(left, right);
        }

        public static bool operator !=(HVACWaterSystem? left, HVACWaterSystem? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}