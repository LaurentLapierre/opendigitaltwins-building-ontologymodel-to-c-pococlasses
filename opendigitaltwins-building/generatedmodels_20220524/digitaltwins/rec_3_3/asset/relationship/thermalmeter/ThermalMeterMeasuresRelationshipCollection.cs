using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Linq;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset.relationship.thermalmeter
{

    public class ThermalMeterMeasuresRelationshipCollection : RelationshipCollection<ThermalMeterMeasuresRelationship, BasicDigitalTwin>
    {
        public ThermalMeterMeasuresRelationshipCollection(IEnumerable<ThermalMeterMeasuresRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<ThermalMeterMeasuresRelationship>())
        {
        }
    }
}