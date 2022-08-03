using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class DedicatedOutdoorAirSystem : AirHandlingUnit, IEquatable<DedicatedOutdoorAirSystem>
    {
        public DedicatedOutdoorAirSystem()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:DedicatedOutdoorAirSystem;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as DedicatedOutdoorAirSystem);
        }

        public bool Equals(DedicatedOutdoorAirSystem? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(DedicatedOutdoorAirSystem? left, DedicatedOutdoorAirSystem? right)
        {
            return EqualityComparer<DedicatedOutdoorAirSystem?>.Default.Equals(left, right);
        }

        public static bool operator !=(DedicatedOutdoorAirSystem? left, DedicatedOutdoorAirSystem? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}