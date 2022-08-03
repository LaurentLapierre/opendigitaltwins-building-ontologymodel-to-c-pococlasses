using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class NormalFaultActuator : BinaryActuator, IEquatable<NormalFaultActuator>
    {
        public NormalFaultActuator()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:NormalFaultActuator;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as NormalFaultActuator);
        }

        public bool Equals(NormalFaultActuator? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(NormalFaultActuator? left, NormalFaultActuator? right)
        {
            return EqualityComparer<NormalFaultActuator?>.Default.Equals(left, right);
        }

        public static bool operator !=(NormalFaultActuator? left, NormalFaultActuator? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}