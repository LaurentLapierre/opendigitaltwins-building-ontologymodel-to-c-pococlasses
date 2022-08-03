using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.agents;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Linq;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.agents.relationship.person
{

    public class PersonIsMemberOfRelationshipCollection : RelationshipCollection<PersonIsMemberOfRelationship, Organization>
    {
        public PersonIsMemberOfRelationshipCollection(IEnumerable<PersonIsMemberOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PersonIsMemberOfRelationship>())
        {
        }
    }
}