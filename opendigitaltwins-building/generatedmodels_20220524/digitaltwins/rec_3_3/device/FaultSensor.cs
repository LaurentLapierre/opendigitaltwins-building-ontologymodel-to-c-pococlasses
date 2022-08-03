using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class FaultSensor : NormalFaultSensor, IEquatable<FaultSensor>
    {
        public FaultSensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:FaultSensor;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as FaultSensor);
        }

        public bool Equals(FaultSensor? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(FaultSensor? left, FaultSensor? right)
        {
            return EqualityComparer<FaultSensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(FaultSensor? left, FaultSensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}