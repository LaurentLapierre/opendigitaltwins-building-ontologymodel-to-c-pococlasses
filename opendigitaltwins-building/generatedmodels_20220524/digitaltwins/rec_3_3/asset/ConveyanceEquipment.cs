using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class ConveyanceEquipment : Equipment, IEquatable<ConveyanceEquipment>
    {
        public ConveyanceEquipment()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:ConveyanceEquipment;1";
        [JsonPropertyName("type")]
        public string? Type { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as ConveyanceEquipment);
        }

        public bool Equals(ConveyanceEquipment? other)
        {
            return other is not null && base.Equals(other) && Type == other.Type;
        }

        public static bool operator ==(ConveyanceEquipment? left, ConveyanceEquipment? right)
        {
            return EqualityComparer<ConveyanceEquipment?>.Default.Equals(left, right);
        }

        public static bool operator !=(ConveyanceEquipment? left, ConveyanceEquipment? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Type?.GetHashCode());
        }
    }
}