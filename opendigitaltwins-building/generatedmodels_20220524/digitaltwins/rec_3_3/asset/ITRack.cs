using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class ITRack : ICTEquipment, IEquatable<ITRack>
    {
        public ITRack()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:ITRack;1";
        [JsonPropertyName("type")]
        public ITRackType? Type { get; set; }
        [JsonPropertyName("mounting")]
        public ITRackMounting? Mounting { get; set; }
        [JsonPropertyName("heightRUs")]
        public int? HeightRUs { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as ITRack);
        }

        public bool Equals(ITRack? other)
        {
            return other is not null && base.Equals(other) && Type == other.Type && Mounting == other.Mounting && HeightRUs == other.HeightRUs;
        }

        public static bool operator ==(ITRack? left, ITRack? right)
        {
            return EqualityComparer<ITRack?>.Default.Equals(left, right);
        }

        public static bool operator !=(ITRack? left, ITRack? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Type?.GetHashCode(), Mounting?.GetHashCode(), HeightRUs?.GetHashCode());
        }
    }
}