using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class DomesticHotWaterSystem : DomesticWaterSystem, IEquatable<DomesticHotWaterSystem>
    {
        public DomesticHotWaterSystem()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:DomesticHotWaterSystem;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as DomesticHotWaterSystem);
        }

        public bool Equals(DomesticHotWaterSystem? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(DomesticHotWaterSystem? left, DomesticHotWaterSystem? right)
        {
            return EqualityComparer<DomesticHotWaterSystem?>.Default.Equals(left, right);
        }

        public static bool operator !=(DomesticHotWaterSystem? left, DomesticHotWaterSystem? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}