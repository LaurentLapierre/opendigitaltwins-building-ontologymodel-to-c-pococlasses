using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class TransferSwitch : ElectricalDistributionEquipment, IEquatable<TransferSwitch>
    {
        public TransferSwitch()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:TransferSwitch;1";
        [JsonPropertyName("poles")]
        public TransferSwitchPoles? Poles { get; set; }
        [JsonPropertyName("mainsRating")]
        public double? MainsRating { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as TransferSwitch);
        }

        public bool Equals(TransferSwitch? other)
        {
            return other is not null && base.Equals(other) && Poles == other.Poles && MainsRating == other.MainsRating;
        }

        public static bool operator ==(TransferSwitch? left, TransferSwitch? right)
        {
            return EqualityComparer<TransferSwitch?>.Default.Equals(left, right);
        }

        public static bool operator !=(TransferSwitch? left, TransferSwitch? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Poles?.GetHashCode(), MainsRating?.GetHashCode());
        }
    }
}