using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.core.relationship.campus;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.core
{

    public class Campus : SpaceCollection, IEquatable<Campus>
    {
        public Campus()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:core:Campus;1";
        [JsonIgnore]
        public CampusOperatedByRelationshipCollection OperatedBy { get; set; } = new CampusOperatedByRelationshipCollection();
        [JsonIgnore]
        public CampusIncludesRelationshipCollection Includes { get; set; } = new CampusIncludesRelationshipCollection();
        public override bool Equals(object? obj)
        {
            return Equals(obj as Campus);
        }

        public bool Equals(Campus? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(Campus? left, Campus? right)
        {
            return EqualityComparer<Campus?>.Default.Equals(left, right);
        }

        public static bool operator !=(Campus? left, Campus? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}