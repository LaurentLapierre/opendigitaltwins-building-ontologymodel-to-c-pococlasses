using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class HVACOutsideAirSystem : HVACConditionedAirSystem, IEquatable<HVACOutsideAirSystem>
    {
        public HVACOutsideAirSystem()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:HVACOutsideAirSystem;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as HVACOutsideAirSystem);
        }

        public bool Equals(HVACOutsideAirSystem? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(HVACOutsideAirSystem? left, HVACOutsideAirSystem? right)
        {
            return EqualityComparer<HVACOutsideAirSystem?>.Default.Equals(left, right);
        }

        public static bool operator !=(HVACOutsideAirSystem? left, HVACOutsideAirSystem? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}