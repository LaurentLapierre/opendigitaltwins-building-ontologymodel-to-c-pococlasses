using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class Chair : Furniture, IEquatable<Chair>
    {
        public Chair()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:Chair;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as Chair);
        }

        public bool Equals(Chair? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(Chair? left, Chair? right)
        {
            return EqualityComparer<Chair?>.Default.Equals(left, right);
        }

        public static bool operator !=(Chair? left, Chair? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}