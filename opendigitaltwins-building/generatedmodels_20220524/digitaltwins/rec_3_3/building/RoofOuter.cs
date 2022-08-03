using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.core;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.building
{

    public class RoofOuter : BuildingComponent, IEquatable<RoofOuter>
    {
        public RoofOuter()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:building:RoofOuter;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as RoofOuter);
        }

        public bool Equals(RoofOuter? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(RoofOuter? left, RoofOuter? right)
        {
            return EqualityComparer<RoofOuter?>.Default.Equals(left, right);
        }

        public static bool operator !=(RoofOuter? left, RoofOuter? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}