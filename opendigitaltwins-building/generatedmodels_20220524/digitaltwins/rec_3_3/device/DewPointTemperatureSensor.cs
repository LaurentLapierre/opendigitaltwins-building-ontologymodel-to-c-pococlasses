using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class DewPointTemperatureSensor : TemperatureSensor, IEquatable<DewPointTemperatureSensor>
    {
        public DewPointTemperatureSensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:DewPointTemperatureSensor;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as DewPointTemperatureSensor);
        }

        public bool Equals(DewPointTemperatureSensor? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(DewPointTemperatureSensor? left, DewPointTemperatureSensor? right)
        {
            return EqualityComparer<DewPointTemperatureSensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(DewPointTemperatureSensor? left, DewPointTemperatureSensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}