using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.asset;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Linq;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset.relationship.faucet
{

    public class FaucetMountedOnRelationshipCollection : RelationshipCollection<FaucetMountedOnRelationship, Sink>
    {
        public FaucetMountedOnRelationshipCollection(IEnumerable<FaucetMountedOnRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<FaucetMountedOnRelationship>())
        {
        }
    }
}