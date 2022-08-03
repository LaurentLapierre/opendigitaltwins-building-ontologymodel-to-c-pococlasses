using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.core;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class MultiStateActuator : Actuator, IEquatable<MultiStateActuator>
    {
        public MultiStateActuator()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:MultiStateActuator;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as MultiStateActuator);
        }

        public bool Equals(MultiStateActuator? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(MultiStateActuator? left, MultiStateActuator? right)
        {
            return EqualityComparer<MultiStateActuator?>.Default.Equals(left, right);
        }

        public static bool operator !=(MultiStateActuator? left, MultiStateActuator? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}