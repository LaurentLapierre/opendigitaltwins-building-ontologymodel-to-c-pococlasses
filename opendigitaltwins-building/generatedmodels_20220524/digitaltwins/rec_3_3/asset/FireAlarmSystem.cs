using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class FireAlarmSystem : FireProtectionSystem, IEquatable<FireAlarmSystem>
    {
        public FireAlarmSystem()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:FireAlarmSystem;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as FireAlarmSystem);
        }

        public bool Equals(FireAlarmSystem? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(FireAlarmSystem? left, FireAlarmSystem? right)
        {
            return EqualityComparer<FireAlarmSystem?>.Default.Equals(left, right);
        }

        public static bool operator !=(FireAlarmSystem? left, FireAlarmSystem? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}