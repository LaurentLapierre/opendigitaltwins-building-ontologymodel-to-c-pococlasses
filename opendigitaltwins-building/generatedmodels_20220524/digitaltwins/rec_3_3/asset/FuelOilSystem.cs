using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class FuelOilSystem : PlumbingSystem, IEquatable<FuelOilSystem>
    {
        public FuelOilSystem()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:FuelOilSystem;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as FuelOilSystem);
        }

        public bool Equals(FuelOilSystem? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(FuelOilSystem? left, FuelOilSystem? right)
        {
            return EqualityComparer<FuelOilSystem?>.Default.Equals(left, right);
        }

        public static bool operator !=(FuelOilSystem? left, FuelOilSystem? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}