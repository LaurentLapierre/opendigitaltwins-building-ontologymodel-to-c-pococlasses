using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class Valve : Component, IEquatable<Valve>
    {
        public Valve()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:Valve;2";
        [JsonPropertyName("pressureCapacity")]
        public double? PressureCapacity { get; set; }
        [JsonPropertyName("flowCapacity")]
        public double? FlowCapacity { get; set; }
        [JsonPropertyName("pipeOutlet")]
        public PipeConnection? PipeOutlet { get; set; }
        [JsonPropertyName("pipeInlet")]
        public PipeConnection? PipeInlet { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as Valve);
        }

        public bool Equals(Valve? other)
        {
            return other is not null && base.Equals(other) && PressureCapacity == other.PressureCapacity && FlowCapacity == other.FlowCapacity && PipeOutlet == other.PipeOutlet && PipeInlet == other.PipeInlet;
        }

        public static bool operator ==(Valve? left, Valve? right)
        {
            return EqualityComparer<Valve?>.Default.Equals(left, right);
        }

        public static bool operator !=(Valve? left, Valve? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), PressureCapacity?.GetHashCode(), FlowCapacity?.GetHashCode(), PipeOutlet?.GetHashCode(), PipeInlet?.GetHashCode());
        }
    }
}