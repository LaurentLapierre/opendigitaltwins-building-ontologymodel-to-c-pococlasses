using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class PropaneSystem : GasSystem, IEquatable<PropaneSystem>
    {
        public PropaneSystem()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:PropaneSystem;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as PropaneSystem);
        }

        public bool Equals(PropaneSystem? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(PropaneSystem? left, PropaneSystem? right)
        {
            return EqualityComparer<PropaneSystem?>.Default.Equals(left, right);
        }

        public static bool operator !=(PropaneSystem? left, PropaneSystem? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}