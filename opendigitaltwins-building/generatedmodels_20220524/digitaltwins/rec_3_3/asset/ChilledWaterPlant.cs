using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class ChilledWaterPlant : HVACEquipmentGroup, IEquatable<ChilledWaterPlant>
    {
        public ChilledWaterPlant()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:ChilledWaterPlant;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as ChilledWaterPlant);
        }

        public bool Equals(ChilledWaterPlant? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(ChilledWaterPlant? left, ChilledWaterPlant? right)
        {
            return EqualityComparer<ChilledWaterPlant?>.Default.Equals(left, right);
        }

        public static bool operator !=(ChilledWaterPlant? left, ChilledWaterPlant? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}