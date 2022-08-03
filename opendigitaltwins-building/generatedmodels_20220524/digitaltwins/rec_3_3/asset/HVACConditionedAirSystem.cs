using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class HVACConditionedAirSystem : HVACAirSystem, IEquatable<HVACConditionedAirSystem>
    {
        public HVACConditionedAirSystem()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:HVACConditionedAirSystem;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as HVACConditionedAirSystem);
        }

        public bool Equals(HVACConditionedAirSystem? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(HVACConditionedAirSystem? left, HVACConditionedAirSystem? right)
        {
            return EqualityComparer<HVACConditionedAirSystem?>.Default.Equals(left, right);
        }

        public static bool operator !=(HVACConditionedAirSystem? left, HVACConditionedAirSystem? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}