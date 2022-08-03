using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class Transformer : ElectricalDistributionEquipment, IEquatable<Transformer>
    {
        public Transformer()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:Transformer;1";
        [JsonPropertyName("voltageSecondary")]
        public double? VoltageSecondary { get; set; }
        [JsonPropertyName("voltagePrimary")]
        public double? VoltagePrimary { get; set; }
        [JsonPropertyName("type")]
        public string? Type { get; set; }
        [JsonPropertyName("sizeKVA")]
        public int? SizeKVA { get; set; }
        [JsonPropertyName("phases")]
        public TransformerPhases? Phases { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as Transformer);
        }

        public bool Equals(Transformer? other)
        {
            return other is not null && base.Equals(other) && VoltageSecondary == other.VoltageSecondary && VoltagePrimary == other.VoltagePrimary && Type == other.Type && SizeKVA == other.SizeKVA && Phases == other.Phases;
        }

        public static bool operator ==(Transformer? left, Transformer? right)
        {
            return EqualityComparer<Transformer?>.Default.Equals(left, right);
        }

        public static bool operator !=(Transformer? left, Transformer? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), VoltageSecondary?.GetHashCode(), VoltagePrimary?.GetHashCode(), Type?.GetHashCode(), SizeKVA?.GetHashCode(), Phases?.GetHashCode());
        }
    }
}