using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Linq;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.business.relationship.lease
{

    public class LeaseLeaseOfRelationshipCollection : RelationshipCollection<LeaseLeaseOfRelationship, BasicDigitalTwin>
    {
        public LeaseLeaseOfRelationshipCollection(IEnumerable<LeaseLeaseOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<LeaseLeaseOfRelationship>())
        {
        }
    }
}