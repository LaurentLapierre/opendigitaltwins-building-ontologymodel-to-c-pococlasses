using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.building
{

    public class Classroom : EducationalRoom, IEquatable<Classroom>
    {
        public Classroom()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:building:Classroom;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as Classroom);
        }

        public bool Equals(Classroom? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(Classroom? left, Classroom? right)
        {
            return EqualityComparer<Classroom?>.Default.Equals(left, right);
        }

        public static bool operator !=(Classroom? left, Classroom? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}