using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class HVACReturnAirSystem : HVACConditionedAirSystem, IEquatable<HVACReturnAirSystem>
    {
        public HVACReturnAirSystem()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:HVACReturnAirSystem;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as HVACReturnAirSystem);
        }

        public bool Equals(HVACReturnAirSystem? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(HVACReturnAirSystem? left, HVACReturnAirSystem? right)
        {
            return EqualityComparer<HVACReturnAirSystem?>.Default.Equals(left, right);
        }

        public static bool operator !=(HVACReturnAirSystem? left, HVACReturnAirSystem? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}