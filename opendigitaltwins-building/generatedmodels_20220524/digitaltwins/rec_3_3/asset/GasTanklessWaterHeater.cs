using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class GasTanklessWaterHeater : TanklessWaterHeater, IEquatable<GasTanklessWaterHeater>
    {
        public GasTanklessWaterHeater()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:GasTanklessWaterHeater;1";
        [JsonPropertyName("powerInput")]
        public double? PowerInput { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as GasTanklessWaterHeater);
        }

        public bool Equals(GasTanklessWaterHeater? other)
        {
            return other is not null && base.Equals(other) && PowerInput == other.PowerInput;
        }

        public static bool operator ==(GasTanklessWaterHeater? left, GasTanklessWaterHeater? right)
        {
            return EqualityComparer<GasTanklessWaterHeater?>.Default.Equals(left, right);
        }

        public static bool operator !=(GasTanklessWaterHeater? left, GasTanklessWaterHeater? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), PowerInput?.GetHashCode());
        }
    }
}