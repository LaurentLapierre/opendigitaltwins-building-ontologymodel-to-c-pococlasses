using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.core;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Linq;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.core.relationship.logicaldevice
{

    public class LogicalDeviceHostedByRelationshipCollection : RelationshipCollection<LogicalDeviceHostedByRelationship, Asset>
    {
        public LogicalDeviceHostedByRelationshipCollection(IEnumerable<LogicalDeviceHostedByRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<LogicalDeviceHostedByRelationship>())
        {
        }
    }
}