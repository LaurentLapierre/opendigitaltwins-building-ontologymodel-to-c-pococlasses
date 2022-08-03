using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class VoltageSensor : QuantitySensor, IEquatable<VoltageSensor>
    {
        public VoltageSensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:VoltageSensor;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as VoltageSensor);
        }

        public bool Equals(VoltageSensor? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(VoltageSensor? left, VoltageSensor? right)
        {
            return EqualityComparer<VoltageSensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(VoltageSensor? left, VoltageSensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}