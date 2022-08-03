using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.asset;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Linq;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset.relationship.furniturecollection
{

    public class FurnitureCollectionIncludesRelationshipCollection : RelationshipCollection<FurnitureCollectionIncludesRelationship, Furniture>
    {
        public FurnitureCollectionIncludesRelationshipCollection(IEnumerable<FurnitureCollectionIncludesRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<FurnitureCollectionIncludesRelationship>())
        {
        }
    }
}