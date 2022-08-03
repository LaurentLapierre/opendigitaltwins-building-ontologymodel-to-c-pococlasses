using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class ElectricalBus : Component, IEquatable<ElectricalBus>
    {
        public ElectricalBus()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:ElectricalBus;1";
        [JsonPropertyName("material")]
        public ElectricalBusMaterial? Material { get; set; }
        [JsonPropertyName("currentRating")]
        public double? CurrentRating { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as ElectricalBus);
        }

        public bool Equals(ElectricalBus? other)
        {
            return other is not null && base.Equals(other) && Material == other.Material && CurrentRating == other.CurrentRating;
        }

        public static bool operator ==(ElectricalBus? left, ElectricalBus? right)
        {
            return EqualityComparer<ElectricalBus?>.Default.Equals(left, right);
        }

        public static bool operator !=(ElectricalBus? left, ElectricalBus? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Material?.GetHashCode(), CurrentRating?.GetHashCode());
        }
    }
}