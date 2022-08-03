using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.core;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class Component : Asset, IEquatable<Component>
    {
        public Component()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:Component;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as Component);
        }

        public bool Equals(Component? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(Component? left, Component? right)
        {
            return EqualityComparer<Component?>.Default.Equals(left, right);
        }

        public static bool operator !=(Component? left, Component? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}