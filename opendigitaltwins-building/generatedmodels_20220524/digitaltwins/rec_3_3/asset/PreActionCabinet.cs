using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class PreActionCabinet : PreActionEquipment, IEquatable<PreActionCabinet>
    {
        public PreActionCabinet()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:PreActionCabinet;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as PreActionCabinet);
        }

        public bool Equals(PreActionCabinet? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(PreActionCabinet? left, PreActionCabinet? right)
        {
            return EqualityComparer<PreActionCabinet?>.Default.Equals(left, right);
        }

        public static bool operator !=(PreActionCabinet? left, PreActionCabinet? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}