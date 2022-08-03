using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class IAQSensorEquipment : SensorEquipment, IEquatable<IAQSensorEquipment>
    {
        public IAQSensorEquipment()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:IAQSensorEquipment;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as IAQSensorEquipment);
        }

        public bool Equals(IAQSensorEquipment? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(IAQSensorEquipment? left, IAQSensorEquipment? right)
        {
            return EqualityComparer<IAQSensorEquipment?>.Default.Equals(left, right);
        }

        public static bool operator !=(IAQSensorEquipment? left, IAQSensorEquipment? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}