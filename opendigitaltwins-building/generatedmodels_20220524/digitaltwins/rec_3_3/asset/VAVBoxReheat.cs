using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class VAVBoxReheat : VAVBox, IEquatable<VAVBoxReheat>
    {
        public VAVBoxReheat()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:VAVBoxReheat;1";
        [JsonPropertyName("nominalHeatingCapacity")]
        public double? NominalHeatingCapacity { get; set; }
        [JsonPropertyName("reHeatingMethod")]
        public HVACHeatingMethod? ReHeatingMethod { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as VAVBoxReheat);
        }

        public bool Equals(VAVBoxReheat? other)
        {
            return other is not null && base.Equals(other) && NominalHeatingCapacity == other.NominalHeatingCapacity && ReHeatingMethod == other.ReHeatingMethod;
        }

        public static bool operator ==(VAVBoxReheat? left, VAVBoxReheat? right)
        {
            return EqualityComparer<VAVBoxReheat?>.Default.Equals(left, right);
        }

        public static bool operator !=(VAVBoxReheat? left, VAVBoxReheat? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), NominalHeatingCapacity?.GetHashCode(), ReHeatingMethod?.GetHashCode());
        }
    }
}