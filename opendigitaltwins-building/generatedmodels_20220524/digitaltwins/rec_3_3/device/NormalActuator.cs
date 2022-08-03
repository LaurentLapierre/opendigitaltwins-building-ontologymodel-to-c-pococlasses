using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class NormalActuator : NormalFaultActuator, IEquatable<NormalActuator>
    {
        public NormalActuator()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:NormalActuator;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as NormalActuator);
        }

        public bool Equals(NormalActuator? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(NormalActuator? left, NormalActuator? right)
        {
            return EqualityComparer<NormalActuator?>.Default.Equals(left, right);
        }

        public static bool operator !=(NormalActuator? left, NormalActuator? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}