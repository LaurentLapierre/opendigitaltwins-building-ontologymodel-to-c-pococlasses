using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class Generator : ElectricalGenerationStorageEquipment, IEquatable<Generator>
    {
        public Generator()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:Generator;1";
        [JsonPropertyName("outputVoltage")]
        public double? OutputVoltage { get; set; }
        [JsonPropertyName("outputPhases")]
        public GeneratorOutputPhases? OutputPhases { get; set; }
        [JsonPropertyName("modeOfOperation")]
        public string? ModeOfOperation { get; set; }
        [JsonPropertyName("fuelType")]
        public string? FuelType { get; set; }
        [JsonPropertyName("frequency")]
        public int? Frequency { get; set; }
        [JsonPropertyName("dayTankCapacity")]
        public double? DayTankCapacity { get; set; }
        [JsonPropertyName("bulkStorageCapacity")]
        public double? BulkStorageCapacity { get; set; }
        [JsonPropertyName("standbyPowerKVA")]
        public int? StandbyPowerKVA { get; set; }
        [JsonPropertyName("standbyPower")]
        public double? StandbyPower { get; set; }
        [JsonPropertyName("primePowerKVA")]
        public int? PrimePowerKVA { get; set; }
        [JsonPropertyName("primePower")]
        public double? PrimePower { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as Generator);
        }

        public bool Equals(Generator? other)
        {
            return other is not null && base.Equals(other) && OutputVoltage == other.OutputVoltage && OutputPhases == other.OutputPhases && ModeOfOperation == other.ModeOfOperation && FuelType == other.FuelType && Frequency == other.Frequency && DayTankCapacity == other.DayTankCapacity && BulkStorageCapacity == other.BulkStorageCapacity && StandbyPowerKVA == other.StandbyPowerKVA && StandbyPower == other.StandbyPower && PrimePowerKVA == other.PrimePowerKVA && PrimePower == other.PrimePower;
        }

        public static bool operator ==(Generator? left, Generator? right)
        {
            return EqualityComparer<Generator?>.Default.Equals(left, right);
        }

        public static bool operator !=(Generator? left, Generator? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), OutputVoltage?.GetHashCode(), OutputPhases?.GetHashCode(), ModeOfOperation?.GetHashCode(), FuelType?.GetHashCode(), Frequency?.GetHashCode(), DayTankCapacity?.GetHashCode(), BulkStorageCapacity?.GetHashCode(), StandbyPowerKVA?.GetHashCode(), StandbyPower?.GetHashCode(), PrimePowerKVA?.GetHashCode(), PrimePower?.GetHashCode());
        }
    }
}