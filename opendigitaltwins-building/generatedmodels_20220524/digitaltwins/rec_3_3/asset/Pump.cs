using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class Pump : Component, IEquatable<Pump>
    {
        public Pump()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:Pump;1";
        [JsonPropertyName("type")]
        public PumpType? Type { get; set; }
        [JsonPropertyName("pumpingMedia")]
        public string? PumpingMedia { get; set; }
        [JsonPropertyName("pressureCapacity")]
        public double? PressureCapacity { get; set; }
        [JsonPropertyName("headCapacity")]
        public int? HeadCapacity { get; set; }
        [JsonPropertyName("flowCapacity")]
        public double? FlowCapacity { get; set; }
        [JsonPropertyName("pipeOutlet")]
        public PipeConnection? PipeOutlet { get; set; }
        [JsonPropertyName("pipeInlet")]
        public PipeConnection? PipeInlet { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as Pump);
        }

        public bool Equals(Pump? other)
        {
            return other is not null && base.Equals(other) && Type == other.Type && PumpingMedia == other.PumpingMedia && PressureCapacity == other.PressureCapacity && HeadCapacity == other.HeadCapacity && FlowCapacity == other.FlowCapacity && PipeOutlet == other.PipeOutlet && PipeInlet == other.PipeInlet;
        }

        public static bool operator ==(Pump? left, Pump? right)
        {
            return EqualityComparer<Pump?>.Default.Equals(left, right);
        }

        public static bool operator !=(Pump? left, Pump? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Type?.GetHashCode(), PumpingMedia?.GetHashCode(), PressureCapacity?.GetHashCode(), HeadCapacity?.GetHashCode(), FlowCapacity?.GetHashCode(), PipeOutlet?.GetHashCode(), PipeInlet?.GetHashCode());
        }
    }
}