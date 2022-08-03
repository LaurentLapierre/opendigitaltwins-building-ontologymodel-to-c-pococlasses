using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class GasSystem : PlumbingSystem, IEquatable<GasSystem>
    {
        public GasSystem()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:GasSystem;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as GasSystem);
        }

        public bool Equals(GasSystem? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(GasSystem? left, GasSystem? right)
        {
            return EqualityComparer<GasSystem?>.Default.Equals(left, right);
        }

        public static bool operator !=(GasSystem? left, GasSystem? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}