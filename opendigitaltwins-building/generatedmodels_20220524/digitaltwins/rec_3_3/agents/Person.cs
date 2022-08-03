using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.core;
using opendigitaltwins.building.digitaltwins.rec_3_3.agents.relationship.person;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.agents
{

    public class Person : Agent, IEquatable<Person>
    {
        public Person()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:agents:Person;1";
        [JsonPropertyName("lastName")]
        public string? LastName { get; set; }
        [JsonPropertyName("image")]
        public string? Image { get; set; }
        [JsonPropertyName("givenName")]
        public string? GivenName { get; set; }
        [JsonPropertyName("gender")]
        public string? Gender { get; set; }
        [JsonPropertyName("firstName")]
        public string? FirstName { get; set; }
        [JsonPropertyName("familyName")]
        public string? FamilyName { get; set; }
        [JsonIgnore]
        public PersonIsMemberOfRelationshipCollection IsMemberOf { get; set; } = new PersonIsMemberOfRelationshipCollection();
        public override bool Equals(object? obj)
        {
            return Equals(obj as Person);
        }

        public bool Equals(Person? other)
        {
            return other is not null && base.Equals(other) && LastName == other.LastName && Image == other.Image && GivenName == other.GivenName && Gender == other.Gender && FirstName == other.FirstName && FamilyName == other.FamilyName;
        }

        public static bool operator ==(Person? left, Person? right)
        {
            return EqualityComparer<Person?>.Default.Equals(left, right);
        }

        public static bool operator !=(Person? left, Person? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), LastName?.GetHashCode(), Image?.GetHashCode(), GivenName?.GetHashCode(), Gender?.GetHashCode(), FirstName?.GetHashCode(), FamilyName?.GetHashCode());
        }
    }
}