using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.agents
{

    public class Department : Organization, IEquatable<Department>
    {
        public Department()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:agents:Department;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as Department);
        }

        public bool Equals(Department? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(Department? left, Department? right)
        {
            return EqualityComparer<Department?>.Default.Equals(left, right);
        }

        public static bool operator !=(Department? left, Department? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}