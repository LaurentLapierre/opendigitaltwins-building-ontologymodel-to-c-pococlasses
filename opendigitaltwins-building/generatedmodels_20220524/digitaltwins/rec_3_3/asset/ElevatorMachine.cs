using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class ElevatorMachine : ConveyanceEquipment, IEquatable<ElevatorMachine>
    {
        public ElevatorMachine()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:ElevatorMachine;1";
        [JsonPropertyName("weightCapacity")]
        public double? WeightCapacity { get; set; }
        [JsonPropertyName("motorPower")]
        public double? MotorPower { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as ElevatorMachine);
        }

        public bool Equals(ElevatorMachine? other)
        {
            return other is not null && base.Equals(other) && WeightCapacity == other.WeightCapacity && MotorPower == other.MotorPower;
        }

        public static bool operator ==(ElevatorMachine? left, ElevatorMachine? right)
        {
            return EqualityComparer<ElevatorMachine?>.Default.Equals(left, right);
        }

        public static bool operator !=(ElevatorMachine? left, ElevatorMachine? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), WeightCapacity?.GetHashCode(), MotorPower?.GetHashCode());
        }
    }
}