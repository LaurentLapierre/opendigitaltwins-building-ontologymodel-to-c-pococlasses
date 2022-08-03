using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class PlumbingHeatTracing : PlumbingEquipment, IEquatable<PlumbingHeatTracing>
    {
        public PlumbingHeatTracing()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:PlumbingHeatTracing;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as PlumbingHeatTracing);
        }

        public bool Equals(PlumbingHeatTracing? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(PlumbingHeatTracing? left, PlumbingHeatTracing? right)
        {
            return EqualityComparer<PlumbingHeatTracing?>.Default.Equals(left, right);
        }

        public static bool operator !=(PlumbingHeatTracing? left, PlumbingHeatTracing? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}