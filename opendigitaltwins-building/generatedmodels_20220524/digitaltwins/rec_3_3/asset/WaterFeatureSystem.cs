using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class WaterFeatureSystem : PlumbingWaterSystem, IEquatable<WaterFeatureSystem>
    {
        public WaterFeatureSystem()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:WaterFeatureSystem;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as WaterFeatureSystem);
        }

        public bool Equals(WaterFeatureSystem? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(WaterFeatureSystem? left, WaterFeatureSystem? right)
        {
            return EqualityComparer<WaterFeatureSystem?>.Default.Equals(left, right);
        }

        public static bool operator !=(WaterFeatureSystem? left, WaterFeatureSystem? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}