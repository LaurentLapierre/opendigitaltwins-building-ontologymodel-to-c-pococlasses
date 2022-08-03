using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.core;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.building
{

    public class School : Building, IEquatable<School>
    {
        public School()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:building:School;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as School);
        }

        public bool Equals(School? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(School? left, School? right)
        {
            return EqualityComparer<School?>.Default.Equals(left, right);
        }

        public static bool operator !=(School? left, School? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}