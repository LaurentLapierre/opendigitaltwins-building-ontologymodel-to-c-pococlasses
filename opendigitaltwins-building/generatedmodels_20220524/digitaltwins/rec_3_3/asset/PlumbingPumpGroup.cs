using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class PlumbingPumpGroup : PlumbingEquipmentGroup, IEquatable<PlumbingPumpGroup>
    {
        public PlumbingPumpGroup()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:PlumbingPumpGroup;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as PlumbingPumpGroup);
        }

        public bool Equals(PlumbingPumpGroup? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(PlumbingPumpGroup? left, PlumbingPumpGroup? right)
        {
            return EqualityComparer<PlumbingPumpGroup?>.Default.Equals(left, right);
        }

        public static bool operator !=(PlumbingPumpGroup? left, PlumbingPumpGroup? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}