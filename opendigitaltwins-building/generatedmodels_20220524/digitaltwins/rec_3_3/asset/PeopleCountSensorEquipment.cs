using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class PeopleCountSensorEquipment : SensorEquipment, IEquatable<PeopleCountSensorEquipment>
    {
        public PeopleCountSensorEquipment()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:PeopleCountSensorEquipment;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as PeopleCountSensorEquipment);
        }

        public bool Equals(PeopleCountSensorEquipment? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(PeopleCountSensorEquipment? left, PeopleCountSensorEquipment? right)
        {
            return EqualityComparer<PeopleCountSensorEquipment?>.Default.Equals(left, right);
        }

        public static bool operator !=(PeopleCountSensorEquipment? left, PeopleCountSensorEquipment? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}