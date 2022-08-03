using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.core;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Linq;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.core.relationship.asset
{

    public class AssetIncludedInRelationshipCollection : RelationshipCollection<AssetIncludedInRelationship, Collection>
    {
        public AssetIncludedInRelationshipCollection(IEnumerable<AssetIncludedInRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<AssetIncludedInRelationship>())
        {
        }
    }
}