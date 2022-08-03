using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.core;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.addressing
{

    public class Address : Information, IEquatable<Address>
    {
        public Address()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:addressing:Address;1";
        [JsonPropertyName("region")]
        public string? Region { get; set; }
        [JsonPropertyName("postalCode")]
        public string? PostalCode { get; set; }
        [JsonPropertyName("country")]
        public string? Country { get; set; }
        [JsonPropertyName("city")]
        public string? City { get; set; }
        [JsonPropertyName("addressLine2")]
        public string? AddressLine2 { get; set; }
        [JsonPropertyName("addressLine1")]
        public string? AddressLine1 { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as Address);
        }

        public bool Equals(Address? other)
        {
            return other is not null && base.Equals(other) && Region == other.Region && PostalCode == other.PostalCode && Country == other.Country && City == other.City && AddressLine2 == other.AddressLine2 && AddressLine1 == other.AddressLine1;
        }

        public static bool operator ==(Address? left, Address? right)
        {
            return EqualityComparer<Address?>.Default.Equals(left, right);
        }

        public static bool operator !=(Address? left, Address? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Region?.GetHashCode(), PostalCode?.GetHashCode(), Country?.GetHashCode(), City?.GetHashCode(), AddressLine2?.GetHashCode(), AddressLine1?.GetHashCode());
        }
    }
}