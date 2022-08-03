using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class HVACGreaseExhaustAirSystem : HVACExhaustAirSystem, IEquatable<HVACGreaseExhaustAirSystem>
    {
        public HVACGreaseExhaustAirSystem()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:HVACGreaseExhaustAirSystem;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as HVACGreaseExhaustAirSystem);
        }

        public bool Equals(HVACGreaseExhaustAirSystem? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(HVACGreaseExhaustAirSystem? left, HVACGreaseExhaustAirSystem? right)
        {
            return EqualityComparer<HVACGreaseExhaustAirSystem?>.Default.Equals(left, right);
        }

        public static bool operator !=(HVACGreaseExhaustAirSystem? left, HVACGreaseExhaustAirSystem? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}