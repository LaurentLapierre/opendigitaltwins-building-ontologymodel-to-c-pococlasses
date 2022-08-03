using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Linq;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset.relationship.flushometervalve
{

    public class FlushometerValveMountedOnRelationshipCollection : RelationshipCollection<FlushometerValveMountedOnRelationship, BasicDigitalTwin>
    {
        public FlushometerValveMountedOnRelationshipCollection(IEnumerable<FlushometerValveMountedOnRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<FlushometerValveMountedOnRelationship>())
        {
        }
    }
}