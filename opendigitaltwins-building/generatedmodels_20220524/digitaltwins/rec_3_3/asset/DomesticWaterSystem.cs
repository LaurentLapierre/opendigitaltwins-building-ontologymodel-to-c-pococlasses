using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class DomesticWaterSystem : PlumbingWaterSystem, IEquatable<DomesticWaterSystem>
    {
        public DomesticWaterSystem()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:DomesticWaterSystem;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as DomesticWaterSystem);
        }

        public bool Equals(DomesticWaterSystem? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(DomesticWaterSystem? left, DomesticWaterSystem? right)
        {
            return EqualityComparer<DomesticWaterSystem?>.Default.Equals(left, right);
        }

        public static bool operator !=(DomesticWaterSystem? left, DomesticWaterSystem? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}