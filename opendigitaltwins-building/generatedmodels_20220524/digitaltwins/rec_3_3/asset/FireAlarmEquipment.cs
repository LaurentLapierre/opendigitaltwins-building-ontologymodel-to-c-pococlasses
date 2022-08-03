using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class FireAlarmEquipment : FireProtectionEquipment, IEquatable<FireAlarmEquipment>
    {
        public FireAlarmEquipment()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:FireAlarmEquipment;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as FireAlarmEquipment);
        }

        public bool Equals(FireAlarmEquipment? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(FireAlarmEquipment? left, FireAlarmEquipment? right)
        {
            return EqualityComparer<FireAlarmEquipment?>.Default.Equals(left, right);
        }

        public static bool operator !=(FireAlarmEquipment? left, FireAlarmEquipment? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}