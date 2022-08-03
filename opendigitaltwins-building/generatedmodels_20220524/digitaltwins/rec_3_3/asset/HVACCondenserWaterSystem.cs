using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class HVACCondenserWaterSystem : HVACWaterSystem, IEquatable<HVACCondenserWaterSystem>
    {
        public HVACCondenserWaterSystem()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:HVACCondenserWaterSystem;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as HVACCondenserWaterSystem);
        }

        public bool Equals(HVACCondenserWaterSystem? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(HVACCondenserWaterSystem? left, HVACCondenserWaterSystem? right)
        {
            return EqualityComparer<HVACCondenserWaterSystem?>.Default.Equals(left, right);
        }

        public static bool operator !=(HVACCondenserWaterSystem? left, HVACCondenserWaterSystem? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}