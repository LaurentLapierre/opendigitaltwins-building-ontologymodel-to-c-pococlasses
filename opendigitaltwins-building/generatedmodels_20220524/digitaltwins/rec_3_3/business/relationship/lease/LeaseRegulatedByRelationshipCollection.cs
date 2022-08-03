using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.business;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Linq;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.business.relationship.lease
{

    public class LeaseRegulatedByRelationshipCollection : RelationshipCollection<LeaseRegulatedByRelationship, LeaseContract>
    {
        public LeaseRegulatedByRelationshipCollection(IEnumerable<LeaseRegulatedByRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<LeaseRegulatedByRelationship>())
        {
        }
    }
}