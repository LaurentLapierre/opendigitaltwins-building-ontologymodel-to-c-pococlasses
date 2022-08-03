using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class DomesticHotWaterRecircSystem : DomesticWaterSystem, IEquatable<DomesticHotWaterRecircSystem>
    {
        public DomesticHotWaterRecircSystem()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:DomesticHotWaterRecircSystem;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as DomesticHotWaterRecircSystem);
        }

        public bool Equals(DomesticHotWaterRecircSystem? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(DomesticHotWaterRecircSystem? left, DomesticHotWaterRecircSystem? right)
        {
            return EqualityComparer<DomesticHotWaterRecircSystem?>.Default.Equals(left, right);
        }

        public static bool operator !=(DomesticHotWaterRecircSystem? left, DomesticHotWaterRecircSystem? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}