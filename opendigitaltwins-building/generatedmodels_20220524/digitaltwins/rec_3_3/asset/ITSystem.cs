using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class ITSystem : System, IEquatable<ITSystem>
    {
        public ITSystem()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:ITSystem;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as ITSystem);
        }

        public bool Equals(ITSystem? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(ITSystem? left, ITSystem? right)
        {
            return EqualityComparer<ITSystem?>.Default.Equals(left, right);
        }

        public static bool operator !=(ITSystem? left, ITSystem? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}