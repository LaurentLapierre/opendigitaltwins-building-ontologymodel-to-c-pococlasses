using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.building
{

    public class DisabledToilet : PersonalHygiene, IEquatable<DisabledToilet>
    {
        public DisabledToilet()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:building:DisabledToilet;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as DisabledToilet);
        }

        public bool Equals(DisabledToilet? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(DisabledToilet? left, DisabledToilet? right)
        {
            return EqualityComparer<DisabledToilet?>.Default.Equals(left, right);
        }

        public static bool operator !=(DisabledToilet? left, DisabledToilet? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}