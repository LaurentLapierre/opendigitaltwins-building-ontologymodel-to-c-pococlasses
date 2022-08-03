using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class DomesticNonPotableWaterSystem : DomesticWaterSystem, IEquatable<DomesticNonPotableWaterSystem>
    {
        public DomesticNonPotableWaterSystem()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:DomesticNonPotableWaterSystem;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as DomesticNonPotableWaterSystem);
        }

        public bool Equals(DomesticNonPotableWaterSystem? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(DomesticNonPotableWaterSystem? left, DomesticNonPotableWaterSystem? right)
        {
            return EqualityComparer<DomesticNonPotableWaterSystem?>.Default.Equals(left, right);
        }

        public static bool operator !=(DomesticNonPotableWaterSystem? left, DomesticNonPotableWaterSystem? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}