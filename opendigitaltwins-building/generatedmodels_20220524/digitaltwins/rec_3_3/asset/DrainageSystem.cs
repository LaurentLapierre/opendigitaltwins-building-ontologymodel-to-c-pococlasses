using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class DrainageSystem : PlumbingSystem, IEquatable<DrainageSystem>
    {
        public DrainageSystem()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:DrainageSystem;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as DrainageSystem);
        }

        public bool Equals(DrainageSystem? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(DrainageSystem? left, DrainageSystem? right)
        {
            return EqualityComparer<DrainageSystem?>.Default.Equals(left, right);
        }

        public static bool operator !=(DrainageSystem? left, DrainageSystem? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}