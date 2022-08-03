using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class ResetSensor : DefaultSensor, IEquatable<ResetSensor>
    {
        public ResetSensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:ResetSensor;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as ResetSensor);
        }

        public bool Equals(ResetSensor? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(ResetSensor? left, ResetSensor? right)
        {
            return EqualityComparer<ResetSensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(ResetSensor? left, ResetSensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}