using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class HVACSupplyAirSystem : HVACConditionedAirSystem, IEquatable<HVACSupplyAirSystem>
    {
        public HVACSupplyAirSystem()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:HVACSupplyAirSystem;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as HVACSupplyAirSystem);
        }

        public bool Equals(HVACSupplyAirSystem? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(HVACSupplyAirSystem? left, HVACSupplyAirSystem? right)
        {
            return EqualityComparer<HVACSupplyAirSystem?>.Default.Equals(left, right);
        }

        public static bool operator !=(HVACSupplyAirSystem? left, HVACSupplyAirSystem? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}