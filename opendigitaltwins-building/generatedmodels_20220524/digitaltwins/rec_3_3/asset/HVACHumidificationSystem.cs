using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class HVACHumidificationSystem : HVACWaterSystem, IEquatable<HVACHumidificationSystem>
    {
        public HVACHumidificationSystem()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:HVACHumidificationSystem;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as HVACHumidificationSystem);
        }

        public bool Equals(HVACHumidificationSystem? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(HVACHumidificationSystem? left, HVACHumidificationSystem? right)
        {
            return EqualityComparer<HVACHumidificationSystem?>.Default.Equals(left, right);
        }

        public static bool operator !=(HVACHumidificationSystem? left, HVACHumidificationSystem? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}