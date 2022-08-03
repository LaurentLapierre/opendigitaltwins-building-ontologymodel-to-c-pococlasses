using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class ModeActuator : MultiStateActuator, IEquatable<ModeActuator>
    {
        public ModeActuator()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:ModeActuator;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as ModeActuator);
        }

        public bool Equals(ModeActuator? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(ModeActuator? left, ModeActuator? right)
        {
            return EqualityComparer<ModeActuator?>.Default.Equals(left, right);
        }

        public static bool operator !=(ModeActuator? left, ModeActuator? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}