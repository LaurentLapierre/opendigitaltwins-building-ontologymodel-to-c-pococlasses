using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.asset;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Linq;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset.relationship.architecturalassetcollection
{

    public class ArchitecturalAssetCollectionIncludesRelationshipCollection : RelationshipCollection<ArchitecturalAssetCollectionIncludesRelationship, ArchitecturalAsset>
    {
        public ArchitecturalAssetCollectionIncludesRelationshipCollection(IEnumerable<ArchitecturalAssetCollectionIncludesRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<ArchitecturalAssetCollectionIncludesRelationship>())
        {
        }
    }
}