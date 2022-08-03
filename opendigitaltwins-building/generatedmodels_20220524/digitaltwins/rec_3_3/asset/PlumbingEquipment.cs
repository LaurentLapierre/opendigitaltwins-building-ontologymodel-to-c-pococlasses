using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class PlumbingEquipment : Equipment, IEquatable<PlumbingEquipment>
    {
        public PlumbingEquipment()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:PlumbingEquipment;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as PlumbingEquipment);
        }

        public bool Equals(PlumbingEquipment? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(PlumbingEquipment? left, PlumbingEquipment? right)
        {
            return EqualityComparer<PlumbingEquipment?>.Default.Equals(left, right);
        }

        public static bool operator !=(PlumbingEquipment? left, PlumbingEquipment? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}