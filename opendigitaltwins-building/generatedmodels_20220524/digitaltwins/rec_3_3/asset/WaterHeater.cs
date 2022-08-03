using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class WaterHeater : PlumbingEquipment, IEquatable<WaterHeater>
    {
        public WaterHeater()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:WaterHeater;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as WaterHeater);
        }

        public bool Equals(WaterHeater? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(WaterHeater? left, WaterHeater? right)
        {
            return EqualityComparer<WaterHeater?>.Default.Equals(left, right);
        }

        public static bool operator !=(WaterHeater? left, WaterHeater? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}