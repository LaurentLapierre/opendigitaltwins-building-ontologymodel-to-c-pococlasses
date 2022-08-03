using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.core
{

    public class Workspace : Zone, IEquatable<Workspace>
    {
        public Workspace()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:core:Workspace;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as Workspace);
        }

        public bool Equals(Workspace? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(Workspace? left, Workspace? right)
        {
            return EqualityComparer<Workspace?>.Default.Equals(left, right);
        }

        public static bool operator !=(Workspace? left, Workspace? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}