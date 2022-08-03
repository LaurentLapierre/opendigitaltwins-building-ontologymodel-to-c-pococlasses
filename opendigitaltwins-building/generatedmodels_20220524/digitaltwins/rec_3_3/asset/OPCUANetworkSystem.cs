using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class OPCUANetworkSystem : ControlsSystem, IEquatable<OPCUANetworkSystem>
    {
        public OPCUANetworkSystem()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:OPCUANetworkSystem;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as OPCUANetworkSystem);
        }

        public bool Equals(OPCUANetworkSystem? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(OPCUANetworkSystem? left, OPCUANetworkSystem? right)
        {
            return EqualityComparer<OPCUANetworkSystem?>.Default.Equals(left, right);
        }

        public static bool operator !=(OPCUANetworkSystem? left, OPCUANetworkSystem? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}