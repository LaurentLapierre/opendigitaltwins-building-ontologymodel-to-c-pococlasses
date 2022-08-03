using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.core;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.building
{

    public class Terrace : BuildingComponent, IEquatable<Terrace>
    {
        public Terrace()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:building:Terrace;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as Terrace);
        }

        public bool Equals(Terrace? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(Terrace? left, Terrace? right)
        {
            return EqualityComparer<Terrace?>.Default.Equals(left, right);
        }

        public static bool operator !=(Terrace? left, Terrace? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}