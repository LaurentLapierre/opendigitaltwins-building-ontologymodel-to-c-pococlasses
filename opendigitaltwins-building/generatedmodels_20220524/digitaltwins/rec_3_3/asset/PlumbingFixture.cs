using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class PlumbingFixture : PlumbingEquipment, IEquatable<PlumbingFixture>
    {
        public PlumbingFixture()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:PlumbingFixture;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as PlumbingFixture);
        }

        public bool Equals(PlumbingFixture? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(PlumbingFixture? left, PlumbingFixture? right)
        {
            return EqualityComparer<PlumbingFixture?>.Default.Equals(left, right);
        }

        public static bool operator !=(PlumbingFixture? left, PlumbingFixture? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}