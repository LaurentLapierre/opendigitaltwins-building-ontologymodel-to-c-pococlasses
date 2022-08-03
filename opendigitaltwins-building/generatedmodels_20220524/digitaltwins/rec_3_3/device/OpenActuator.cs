using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class OpenActuator : OpenCloseActuator, IEquatable<OpenActuator>
    {
        public OpenActuator()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:OpenActuator;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as OpenActuator);
        }

        public bool Equals(OpenActuator? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(OpenActuator? left, OpenActuator? right)
        {
            return EqualityComparer<OpenActuator?>.Default.Equals(left, right);
        }

        public static bool operator !=(OpenActuator? left, OpenActuator? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}