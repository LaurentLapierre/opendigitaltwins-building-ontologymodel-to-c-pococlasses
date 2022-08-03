using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class FirePump : SprinklerEquipment, IEquatable<FirePump>
    {
        public FirePump()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:FirePump;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as FirePump);
        }

        public bool Equals(FirePump? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(FirePump? left, FirePump? right)
        {
            return EqualityComparer<FirePump?>.Default.Equals(left, right);
        }

        public static bool operator !=(FirePump? left, FirePump? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}