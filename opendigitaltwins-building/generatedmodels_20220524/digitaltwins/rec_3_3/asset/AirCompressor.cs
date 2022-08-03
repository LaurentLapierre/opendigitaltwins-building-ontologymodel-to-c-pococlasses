using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class AirCompressor : PlumbingEquipment, IEquatable<AirCompressor>
    {
        public AirCompressor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:AirCompressor;1";
        [JsonPropertyName("workingPressure")]
        public double? WorkingPressure { get; set; }
        [JsonPropertyName("motorPower")]
        public double? MotorPower { get; set; }
        [JsonPropertyName("freeAirDelivery")]
        public double? FreeAirDelivery { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as AirCompressor);
        }

        public bool Equals(AirCompressor? other)
        {
            return other is not null && base.Equals(other) && WorkingPressure == other.WorkingPressure && MotorPower == other.MotorPower && FreeAirDelivery == other.FreeAirDelivery;
        }

        public static bool operator ==(AirCompressor? left, AirCompressor? right)
        {
            return EqualityComparer<AirCompressor?>.Default.Equals(left, right);
        }

        public static bool operator !=(AirCompressor? left, AirCompressor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), WorkingPressure?.GetHashCode(), MotorPower?.GetHashCode(), FreeAirDelivery?.GetHashCode());
        }
    }
}