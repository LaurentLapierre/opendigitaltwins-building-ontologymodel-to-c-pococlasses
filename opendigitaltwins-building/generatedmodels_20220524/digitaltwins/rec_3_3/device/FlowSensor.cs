using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class FlowSensor : QuantitySensor, IEquatable<FlowSensor>
    {
        public FlowSensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:FlowSensor;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as FlowSensor);
        }

        public bool Equals(FlowSensor? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(FlowSensor? left, FlowSensor? right)
        {
            return EqualityComparer<FlowSensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(FlowSensor? left, FlowSensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}