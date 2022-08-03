using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.business;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Linq;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.core.relationship.agent
{

    public class AgentHasRoleRelationshipCollection : RelationshipCollection<AgentHasRoleRelationship, Role>
    {
        public AgentHasRoleRelationshipCollection(IEnumerable<AgentHasRoleRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<AgentHasRoleRelationship>())
        {
        }
    }
}