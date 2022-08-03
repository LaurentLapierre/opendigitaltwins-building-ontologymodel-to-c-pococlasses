using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class ElectricalPanelboard : ElectricalDistributionEquipment, IEquatable<ElectricalPanelboard>
    {
        public ElectricalPanelboard()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:ElectricalPanelboard;1";
        [JsonPropertyName("shortCircuitRating")]
        public string? ShortCircuitRating { get; set; }
        [JsonPropertyName("outputPhases")]
        public ElectricalPanelboardOutputPhases? OutputPhases { get; set; }
        [JsonPropertyName("inputVoltage")]
        public double? InputVoltage { get; set; }
        [JsonPropertyName("maxNumberOfPoles")]
        public int? MaxNumberOfPoles { get; set; }
        [JsonPropertyName("mainBus")]
        public ElectricalBus? MainBus { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as ElectricalPanelboard);
        }

        public bool Equals(ElectricalPanelboard? other)
        {
            return other is not null && base.Equals(other) && ShortCircuitRating == other.ShortCircuitRating && OutputPhases == other.OutputPhases && InputVoltage == other.InputVoltage && MaxNumberOfPoles == other.MaxNumberOfPoles && MainBus == other.MainBus;
        }

        public static bool operator ==(ElectricalPanelboard? left, ElectricalPanelboard? right)
        {
            return EqualityComparer<ElectricalPanelboard?>.Default.Equals(left, right);
        }

        public static bool operator !=(ElectricalPanelboard? left, ElectricalPanelboard? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), ShortCircuitRating?.GetHashCode(), OutputPhases?.GetHashCode(), InputVoltage?.GetHashCode(), MaxNumberOfPoles?.GetHashCode(), MainBus?.GetHashCode());
        }
    }
}