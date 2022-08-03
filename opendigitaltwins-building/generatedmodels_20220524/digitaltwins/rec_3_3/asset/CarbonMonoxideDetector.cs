using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class CarbonMonoxideDetector : FireDetectionEquipment, IEquatable<CarbonMonoxideDetector>
    {
        public CarbonMonoxideDetector()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:CarbonMonoxideDetector;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as CarbonMonoxideDetector);
        }

        public bool Equals(CarbonMonoxideDetector? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(CarbonMonoxideDetector? left, CarbonMonoxideDetector? right)
        {
            return EqualityComparer<CarbonMonoxideDetector?>.Default.Equals(left, right);
        }

        public static bool operator !=(CarbonMonoxideDetector? left, CarbonMonoxideDetector? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}