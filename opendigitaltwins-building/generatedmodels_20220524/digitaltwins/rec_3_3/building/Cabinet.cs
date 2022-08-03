using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.building
{

    public class Cabinet : UtilitiesRoom, IEquatable<Cabinet>
    {
        public Cabinet()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:building:Cabinet;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as Cabinet);
        }

        public bool Equals(Cabinet? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(Cabinet? left, Cabinet? right)
        {
            return EqualityComparer<Cabinet?>.Default.Equals(left, right);
        }

        public static bool operator !=(Cabinet? left, Cabinet? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}