using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Linq;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset.relationship.equipment
{

    public class EquipmentIsFedByRelationshipCollection : RelationshipCollection<EquipmentIsFedByRelationship, BasicDigitalTwin>
    {
        public EquipmentIsFedByRelationshipCollection(IEnumerable<EquipmentIsFedByRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<EquipmentIsFedByRelationship>())
        {
        }
    }
}