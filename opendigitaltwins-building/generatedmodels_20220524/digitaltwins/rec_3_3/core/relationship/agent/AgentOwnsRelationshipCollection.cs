using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Linq;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.core.relationship.agent
{

    public class AgentOwnsRelationshipCollection : RelationshipCollection<AgentOwnsRelationship, BasicDigitalTwin>
    {
        public AgentOwnsRelationshipCollection(IEnumerable<AgentOwnsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<AgentOwnsRelationship>())
        {
        }
    }
}