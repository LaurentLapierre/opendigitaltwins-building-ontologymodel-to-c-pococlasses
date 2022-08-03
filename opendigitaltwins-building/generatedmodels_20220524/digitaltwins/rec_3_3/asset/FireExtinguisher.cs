using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class FireExtinguisher : FireSuppressionEquipment, IEquatable<FireExtinguisher>
    {
        public FireExtinguisher()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:FireExtinguisher;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as FireExtinguisher);
        }

        public bool Equals(FireExtinguisher? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(FireExtinguisher? left, FireExtinguisher? right)
        {
            return EqualityComparer<FireExtinguisher?>.Default.Equals(left, right);
        }

        public static bool operator !=(FireExtinguisher? left, FireExtinguisher? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}