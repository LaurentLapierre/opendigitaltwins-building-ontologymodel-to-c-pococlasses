using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.asset;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Linq;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset.relationship.watermeter
{

    public class WaterMeterSubMeterOfRelationshipCollection : RelationshipCollection<WaterMeterSubMeterOfRelationship, WaterMeter>
    {
        public WaterMeterSubMeterOfRelationshipCollection(IEnumerable<WaterMeterSubMeterOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WaterMeterSubMeterOfRelationship>())
        {
        }
    }
}