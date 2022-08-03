using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class HVACExhaustAirSystem : HVACAirSystem, IEquatable<HVACExhaustAirSystem>
    {
        public HVACExhaustAirSystem()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:HVACExhaustAirSystem;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as HVACExhaustAirSystem);
        }

        public bool Equals(HVACExhaustAirSystem? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(HVACExhaustAirSystem? left, HVACExhaustAirSystem? right)
        {
            return EqualityComparer<HVACExhaustAirSystem?>.Default.Equals(left, right);
        }

        public static bool operator !=(HVACExhaustAirSystem? left, HVACExhaustAirSystem? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}