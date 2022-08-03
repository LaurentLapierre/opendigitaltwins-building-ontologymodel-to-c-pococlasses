using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class PreActionEquipment : SprinklerEquipment, IEquatable<PreActionEquipment>
    {
        public PreActionEquipment()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:PreActionEquipment;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as PreActionEquipment);
        }

        public bool Equals(PreActionEquipment? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(PreActionEquipment? left, PreActionEquipment? right)
        {
            return EqualityComparer<PreActionEquipment?>.Default.Equals(left, right);
        }

        public static bool operator !=(PreActionEquipment? left, PreActionEquipment? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}