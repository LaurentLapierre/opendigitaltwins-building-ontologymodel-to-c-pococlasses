using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class LeakDetectorEquipment : SensorEquipment, IEquatable<LeakDetectorEquipment>
    {
        public LeakDetectorEquipment()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:LeakDetectorEquipment;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as LeakDetectorEquipment);
        }

        public bool Equals(LeakDetectorEquipment? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(LeakDetectorEquipment? left, LeakDetectorEquipment? right)
        {
            return EqualityComparer<LeakDetectorEquipment?>.Default.Equals(left, right);
        }

        public static bool operator !=(LeakDetectorEquipment? left, LeakDetectorEquipment? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}