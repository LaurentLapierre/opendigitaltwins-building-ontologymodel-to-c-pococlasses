using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.core
{

    public class Parameter : Capability, IEquatable<Parameter>
    {
        public Parameter()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:core:Parameter;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as Parameter);
        }

        public bool Equals(Parameter? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(Parameter? left, Parameter? right)
        {
            return EqualityComparer<Parameter?>.Default.Equals(left, right);
        }

        public static bool operator !=(Parameter? left, Parameter? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}