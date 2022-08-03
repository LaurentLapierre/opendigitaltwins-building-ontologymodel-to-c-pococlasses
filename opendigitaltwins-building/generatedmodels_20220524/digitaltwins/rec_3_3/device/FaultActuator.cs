using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class FaultActuator : NormalFaultActuator, IEquatable<FaultActuator>
    {
        public FaultActuator()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:FaultActuator;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as FaultActuator);
        }

        public bool Equals(FaultActuator? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(FaultActuator? left, FaultActuator? right)
        {
            return EqualityComparer<FaultActuator?>.Default.Equals(left, right);
        }

        public static bool operator !=(FaultActuator? left, FaultActuator? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}