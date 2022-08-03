using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class SmokeCarbonMonoxideDetector : SmokeDetector, IEquatable<SmokeCarbonMonoxideDetector>
    {
        public SmokeCarbonMonoxideDetector()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:SmokeCarbonMonoxideDetector;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as SmokeCarbonMonoxideDetector);
        }

        public bool Equals(SmokeCarbonMonoxideDetector? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(SmokeCarbonMonoxideDetector? left, SmokeCarbonMonoxideDetector? right)
        {
            return EqualityComparer<SmokeCarbonMonoxideDetector?>.Default.Equals(left, right);
        }

        public static bool operator !=(SmokeCarbonMonoxideDetector? left, SmokeCarbonMonoxideDetector? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}