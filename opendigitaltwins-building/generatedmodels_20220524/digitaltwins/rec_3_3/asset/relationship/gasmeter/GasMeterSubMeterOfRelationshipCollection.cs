using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.asset;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Linq;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset.relationship.gasmeter
{

    public class GasMeterSubMeterOfRelationshipCollection : RelationshipCollection<GasMeterSubMeterOfRelationship, GasMeter>
    {
        public GasMeterSubMeterOfRelationshipCollection(IEnumerable<GasMeterSubMeterOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<GasMeterSubMeterOfRelationship>())
        {
        }
    }
}