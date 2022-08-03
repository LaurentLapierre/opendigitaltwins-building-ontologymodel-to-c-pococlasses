using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.core;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Linq;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.core.relationship.realestate
{

    public class RealEstateOwnedByRelationshipCollection : RelationshipCollection<RealEstateOwnedByRelationship, Agent>
    {
        public RealEstateOwnedByRelationshipCollection(IEnumerable<RealEstateOwnedByRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<RealEstateOwnedByRelationship>())
        {
        }
    }
}