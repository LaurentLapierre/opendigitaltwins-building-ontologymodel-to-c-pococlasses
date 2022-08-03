using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class ElectricalPanelboardMCB : ElectricalPanelboard, IEquatable<ElectricalPanelboardMCB>
    {
        public ElectricalPanelboardMCB()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:ElectricalPanelboardMCB;1";
        [JsonPropertyName("MCBRating")]
        public double? MCBRating { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as ElectricalPanelboardMCB);
        }

        public bool Equals(ElectricalPanelboardMCB? other)
        {
            return other is not null && base.Equals(other) && MCBRating == other.MCBRating;
        }

        public static bool operator ==(ElectricalPanelboardMCB? left, ElectricalPanelboardMCB? right)
        {
            return EqualityComparer<ElectricalPanelboardMCB?>.Default.Equals(left, right);
        }

        public static bool operator !=(ElectricalPanelboardMCB? left, ElectricalPanelboardMCB? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), MCBRating?.GetHashCode());
        }
    }
}