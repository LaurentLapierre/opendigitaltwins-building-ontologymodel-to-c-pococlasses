using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class NormalFaultSensor : BinarySensor, IEquatable<NormalFaultSensor>
    {
        public NormalFaultSensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:NormalFaultSensor;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as NormalFaultSensor);
        }

        public bool Equals(NormalFaultSensor? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(NormalFaultSensor? left, NormalFaultSensor? right)
        {
            return EqualityComparer<NormalFaultSensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(NormalFaultSensor? left, NormalFaultSensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}