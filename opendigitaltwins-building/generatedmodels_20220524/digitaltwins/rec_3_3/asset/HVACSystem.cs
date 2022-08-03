using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class HVACSystem : System, IEquatable<HVACSystem>
    {
        public HVACSystem()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:HVACSystem;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as HVACSystem);
        }

        public bool Equals(HVACSystem? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(HVACSystem? left, HVACSystem? right)
        {
            return EqualityComparer<HVACSystem?>.Default.Equals(left, right);
        }

        public static bool operator !=(HVACSystem? left, HVACSystem? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}