using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.building
{

    public class BicycleGarage : Garage, IEquatable<BicycleGarage>
    {
        public BicycleGarage()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:building:BicycleGarage;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as BicycleGarage);
        }

        public bool Equals(BicycleGarage? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(BicycleGarage? left, BicycleGarage? right)
        {
            return EqualityComparer<BicycleGarage?>.Default.Equals(left, right);
        }

        public static bool operator !=(BicycleGarage? left, BicycleGarage? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}