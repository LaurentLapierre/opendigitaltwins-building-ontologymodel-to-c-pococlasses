using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class OPCDANetworkSystem : ControlsSystem, IEquatable<OPCDANetworkSystem>
    {
        public OPCDANetworkSystem()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:OPCDANetworkSystem;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as OPCDANetworkSystem);
        }

        public bool Equals(OPCDANetworkSystem? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(OPCDANetworkSystem? left, OPCDANetworkSystem? right)
        {
            return EqualityComparer<OPCDANetworkSystem?>.Default.Equals(left, right);
        }

        public static bool operator !=(OPCDANetworkSystem? left, OPCDANetworkSystem? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}