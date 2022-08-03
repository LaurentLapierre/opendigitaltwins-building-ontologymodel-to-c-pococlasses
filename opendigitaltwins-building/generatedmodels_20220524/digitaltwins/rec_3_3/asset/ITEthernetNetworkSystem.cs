using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class ITEthernetNetworkSystem : ITSystem, IEquatable<ITEthernetNetworkSystem>
    {
        public ITEthernetNetworkSystem()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:ITEthernetNetworkSystem;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as ITEthernetNetworkSystem);
        }

        public bool Equals(ITEthernetNetworkSystem? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(ITEthernetNetworkSystem? left, ITEthernetNetworkSystem? right)
        {
            return EqualityComparer<ITEthernetNetworkSystem?>.Default.Equals(left, right);
        }

        public static bool operator !=(ITEthernetNetworkSystem? left, ITEthernetNetworkSystem? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}