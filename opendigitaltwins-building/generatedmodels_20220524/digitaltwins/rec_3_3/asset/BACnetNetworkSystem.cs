using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class BACnetNetworkSystem : ControlsSystem, IEquatable<BACnetNetworkSystem>
    {
        public BACnetNetworkSystem()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:BACnetNetworkSystem;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as BACnetNetworkSystem);
        }

        public bool Equals(BACnetNetworkSystem? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(BACnetNetworkSystem? left, BACnetNetworkSystem? right)
        {
            return EqualityComparer<BACnetNetworkSystem?>.Default.Equals(left, right);
        }

        public static bool operator !=(BACnetNetworkSystem? left, BACnetNetworkSystem? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}