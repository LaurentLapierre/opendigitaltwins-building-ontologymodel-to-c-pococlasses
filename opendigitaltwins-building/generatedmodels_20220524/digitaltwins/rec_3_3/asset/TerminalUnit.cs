using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class TerminalUnit : HVACEquipment, IEquatable<TerminalUnit>
    {
        public TerminalUnit()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:TerminalUnit;1";
        [JsonPropertyName("minAirflowRating")]
        public double? MinAirflowRating { get; set; }
        [JsonPropertyName("maxAirflowRating")]
        public double? MaxAirflowRating { get; set; }
        [JsonPropertyName("ductInlet")]
        public DuctConnection? DuctInlet { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as TerminalUnit);
        }

        public bool Equals(TerminalUnit? other)
        {
            return other is not null && base.Equals(other) && MinAirflowRating == other.MinAirflowRating && MaxAirflowRating == other.MaxAirflowRating && DuctInlet == other.DuctInlet;
        }

        public static bool operator ==(TerminalUnit? left, TerminalUnit? right)
        {
            return EqualityComparer<TerminalUnit?>.Default.Equals(left, right);
        }

        public static bool operator !=(TerminalUnit? left, TerminalUnit? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), MinAirflowRating?.GetHashCode(), MaxAirflowRating?.GetHashCode(), DuctInlet?.GetHashCode());
        }
    }
}