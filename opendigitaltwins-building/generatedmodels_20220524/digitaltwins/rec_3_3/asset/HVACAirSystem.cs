using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class HVACAirSystem : HVACSystem, IEquatable<HVACAirSystem>
    {
        public HVACAirSystem()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:HVACAirSystem;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as HVACAirSystem);
        }

        public bool Equals(HVACAirSystem? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(HVACAirSystem? left, HVACAirSystem? right)
        {
            return EqualityComparer<HVACAirSystem?>.Default.Equals(left, right);
        }

        public static bool operator !=(HVACAirSystem? left, HVACAirSystem? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}