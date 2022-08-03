using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class PlumbingWaterTreatment : PlumbingEquipment, IEquatable<PlumbingWaterTreatment>
    {
        public PlumbingWaterTreatment()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:PlumbingWaterTreatment;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as PlumbingWaterTreatment);
        }

        public bool Equals(PlumbingWaterTreatment? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(PlumbingWaterTreatment? left, PlumbingWaterTreatment? right)
        {
            return EqualityComparer<PlumbingWaterTreatment?>.Default.Equals(left, right);
        }

        public static bool operator !=(PlumbingWaterTreatment? left, PlumbingWaterTreatment? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}