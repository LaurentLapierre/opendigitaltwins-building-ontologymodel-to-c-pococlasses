using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Linq;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset.relationship.equipment
{

    public class EquipmentFeedsRelationshipCollection : RelationshipCollection<EquipmentFeedsRelationship, BasicDigitalTwin>
    {
        public EquipmentFeedsRelationshipCollection(IEnumerable<EquipmentFeedsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<EquipmentFeedsRelationship>())
        {
        }
    }
}