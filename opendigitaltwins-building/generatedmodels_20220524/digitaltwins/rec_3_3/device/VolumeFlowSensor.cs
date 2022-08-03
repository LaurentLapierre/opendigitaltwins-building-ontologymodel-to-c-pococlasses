using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class VolumeFlowSensor : FlowSensor, IEquatable<VolumeFlowSensor>
    {
        public VolumeFlowSensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:VolumeFlowSensor;1";
        [JsonPropertyName("lastValue")]
        public double? LastValue { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as VolumeFlowSensor);
        }

        public bool Equals(VolumeFlowSensor? other)
        {
            return other is not null && base.Equals(other) && LastValue == other.LastValue;
        }

        public static bool operator ==(VolumeFlowSensor? left, VolumeFlowSensor? right)
        {
            return EqualityComparer<VolumeFlowSensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(VolumeFlowSensor? left, VolumeFlowSensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), LastValue?.GetHashCode());
        }
    }
}