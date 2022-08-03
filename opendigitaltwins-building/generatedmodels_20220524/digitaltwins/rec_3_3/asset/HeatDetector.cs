using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class HeatDetector : FireDetectionEquipment, IEquatable<HeatDetector>
    {
        public HeatDetector()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:HeatDetector;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as HeatDetector);
        }

        public bool Equals(HeatDetector? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(HeatDetector? left, HeatDetector? right)
        {
            return EqualityComparer<HeatDetector?>.Default.Equals(left, right);
        }

        public static bool operator !=(HeatDetector? left, HeatDetector? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}