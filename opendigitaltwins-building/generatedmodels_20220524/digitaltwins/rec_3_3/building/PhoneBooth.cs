using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.building
{

    public class PhoneBooth : Office, IEquatable<PhoneBooth>
    {
        public PhoneBooth()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:building:PhoneBooth;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as PhoneBooth);
        }

        public bool Equals(PhoneBooth? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(PhoneBooth? left, PhoneBooth? right)
        {
            return EqualityComparer<PhoneBooth?>.Default.Equals(left, right);
        }

        public static bool operator !=(PhoneBooth? left, PhoneBooth? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}