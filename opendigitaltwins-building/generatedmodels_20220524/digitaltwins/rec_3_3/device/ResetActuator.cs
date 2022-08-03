using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class ResetActuator : DefaultActuator, IEquatable<ResetActuator>
    {
        public ResetActuator()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:ResetActuator;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as ResetActuator);
        }

        public bool Equals(ResetActuator? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(ResetActuator? left, ResetActuator? right)
        {
            return EqualityComparer<ResetActuator?>.Default.Equals(left, right);
        }

        public static bool operator !=(ResetActuator? left, ResetActuator? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}