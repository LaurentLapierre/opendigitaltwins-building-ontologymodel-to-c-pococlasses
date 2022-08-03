using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class OpenCloseActuator : BinaryActuator, IEquatable<OpenCloseActuator>
    {
        public OpenCloseActuator()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:OpenCloseActuator;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as OpenCloseActuator);
        }

        public bool Equals(OpenCloseActuator? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(OpenCloseActuator? left, OpenCloseActuator? right)
        {
            return EqualityComparer<OpenCloseActuator?>.Default.Equals(left, right);
        }

        public static bool operator !=(OpenCloseActuator? left, OpenCloseActuator? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}