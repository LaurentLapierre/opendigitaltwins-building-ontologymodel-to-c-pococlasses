using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class SmokeDetector : FireDetectionEquipment, IEquatable<SmokeDetector>
    {
        public SmokeDetector()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:SmokeDetector;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as SmokeDetector);
        }

        public bool Equals(SmokeDetector? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(SmokeDetector? left, SmokeDetector? right)
        {
            return EqualityComparer<SmokeDetector?>.Default.Equals(left, right);
        }

        public static bool operator !=(SmokeDetector? left, SmokeDetector? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}