using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.core;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.business
{

    public class LeaseContract : Document, IEquatable<LeaseContract>
    {
        public LeaseContract()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:business:LeaseContract;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as LeaseContract);
        }

        public bool Equals(LeaseContract? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(LeaseContract? left, LeaseContract? right)
        {
            return EqualityComparer<LeaseContract?>.Default.Equals(left, right);
        }

        public static bool operator !=(LeaseContract? left, LeaseContract? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}