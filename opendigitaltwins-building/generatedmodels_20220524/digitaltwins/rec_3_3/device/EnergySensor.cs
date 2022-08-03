using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class EnergySensor : QuantitySensor, IEquatable<EnergySensor>
    {
        public EnergySensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:EnergySensor;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as EnergySensor);
        }

        public bool Equals(EnergySensor? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(EnergySensor? left, EnergySensor? right)
        {
            return EqualityComparer<EnergySensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(EnergySensor? left, EnergySensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}