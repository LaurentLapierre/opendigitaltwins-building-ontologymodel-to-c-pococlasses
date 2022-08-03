using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class MakeupAirUnit : AirHandlingUnit, IEquatable<MakeupAirUnit>
    {
        public MakeupAirUnit()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:MakeupAirUnit;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as MakeupAirUnit);
        }

        public bool Equals(MakeupAirUnit? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(MakeupAirUnit? left, MakeupAirUnit? right)
        {
            return EqualityComparer<MakeupAirUnit?>.Default.Equals(left, right);
        }

        public static bool operator !=(MakeupAirUnit? left, MakeupAirUnit? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}