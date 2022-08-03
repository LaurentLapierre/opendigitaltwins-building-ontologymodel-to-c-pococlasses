using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Linq;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.core.relationship.sensor
{

    public class SensorObservesRelationshipCollection : RelationshipCollection<SensorObservesRelationship, BasicDigitalTwin>
    {
        public SensorObservesRelationshipCollection(IEnumerable<SensorObservesRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<SensorObservesRelationship>())
        {
        }
    }
}