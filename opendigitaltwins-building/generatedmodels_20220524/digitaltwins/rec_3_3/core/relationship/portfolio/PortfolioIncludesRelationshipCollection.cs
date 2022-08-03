using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Linq;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.core.relationship.portfolio
{

    public class PortfolioIncludesRelationshipCollection : RelationshipCollection<PortfolioIncludesRelationship, BasicDigitalTwin>
    {
        public PortfolioIncludesRelationshipCollection(IEnumerable<PortfolioIncludesRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PortfolioIncludesRelationship>())
        {
        }
    }
}