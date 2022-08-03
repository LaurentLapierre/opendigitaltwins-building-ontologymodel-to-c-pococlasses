using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Linq;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.core.relationship.capability
{

    public class CapabilityServesRelationshipCollection : RelationshipCollection<CapabilityServesRelationship, BasicDigitalTwin>
    {
        public CapabilityServesRelationshipCollection(IEnumerable<CapabilityServesRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<CapabilityServesRelationship>())
        {
        }
    }
}