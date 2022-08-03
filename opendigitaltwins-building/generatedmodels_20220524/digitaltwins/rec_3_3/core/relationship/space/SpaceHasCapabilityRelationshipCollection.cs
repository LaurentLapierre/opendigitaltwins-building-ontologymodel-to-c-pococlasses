using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.core;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Linq;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.core.relationship.space
{

    public class SpaceHasCapabilityRelationshipCollection : RelationshipCollection<SpaceHasCapabilityRelationship, Capability>
    {
        public SpaceHasCapabilityRelationshipCollection(IEnumerable<SpaceHasCapabilityRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<SpaceHasCapabilityRelationship>())
        {
        }
    }
}