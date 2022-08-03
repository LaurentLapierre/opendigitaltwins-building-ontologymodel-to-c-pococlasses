using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Linq;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset.relationship.watermeter
{

    public class WaterMeterMeasuresRelationshipCollection : RelationshipCollection<WaterMeterMeasuresRelationship, BasicDigitalTwin>
    {
        public WaterMeterMeasuresRelationshipCollection(IEnumerable<WaterMeterMeasuresRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WaterMeterMeasuresRelationship>())
        {
        }
    }
}