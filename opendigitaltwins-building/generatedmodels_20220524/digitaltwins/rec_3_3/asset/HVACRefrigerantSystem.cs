using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class HVACRefrigerantSystem : HVACSystem, IEquatable<HVACRefrigerantSystem>
    {
        public HVACRefrigerantSystem()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:HVACRefrigerantSystem;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as HVACRefrigerantSystem);
        }

        public bool Equals(HVACRefrigerantSystem? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(HVACRefrigerantSystem? left, HVACRefrigerantSystem? right)
        {
            return EqualityComparer<HVACRefrigerantSystem?>.Default.Equals(left, right);
        }

        public static bool operator !=(HVACRefrigerantSystem? left, HVACRefrigerantSystem? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}