using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class Busway : ElectricalDistributionEquipment, IEquatable<Busway>
    {
        public Busway()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:Busway;1";
        [JsonPropertyName("shortCircuitRating")]
        public string? ShortCircuitRating { get; set; }
        [JsonPropertyName("inputVoltage")]
        public double? InputVoltage { get; set; }
        [JsonPropertyName("inputPhases")]
        public BuswayInputPhases? InputPhases { get; set; }
        [JsonPropertyName("mainBus")]
        public ElectricalBus? MainBus { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as Busway);
        }

        public bool Equals(Busway? other)
        {
            return other is not null && base.Equals(other) && ShortCircuitRating == other.ShortCircuitRating && InputVoltage == other.InputVoltage && InputPhases == other.InputPhases && MainBus == other.MainBus;
        }

        public static bool operator ==(Busway? left, Busway? right)
        {
            return EqualityComparer<Busway?>.Default.Equals(left, right);
        }

        public static bool operator !=(Busway? left, Busway? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), ShortCircuitRating?.GetHashCode(), InputVoltage?.GetHashCode(), InputPhases?.GetHashCode(), MainBus?.GetHashCode());
        }
    }
}