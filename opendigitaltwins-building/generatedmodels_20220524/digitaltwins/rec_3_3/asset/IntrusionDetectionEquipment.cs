using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class IntrusionDetectionEquipment : SecurityEquipment, IEquatable<IntrusionDetectionEquipment>
    {
        public IntrusionDetectionEquipment()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:IntrusionDetectionEquipment;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as IntrusionDetectionEquipment);
        }

        public bool Equals(IntrusionDetectionEquipment? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(IntrusionDetectionEquipment? left, IntrusionDetectionEquipment? right)
        {
            return EqualityComparer<IntrusionDetectionEquipment?>.Default.Equals(left, right);
        }

        public static bool operator !=(IntrusionDetectionEquipment? left, IntrusionDetectionEquipment? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}