using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.core;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class QuantitySensor : Sensor, IEquatable<QuantitySensor>
    {
        public QuantitySensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:QuantitySensor;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as QuantitySensor);
        }

        public bool Equals(QuantitySensor? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(QuantitySensor? left, QuantitySensor? right)
        {
            return EqualityComparer<QuantitySensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(QuantitySensor? left, QuantitySensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}