using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class HumidityRatioSensor : HumiditySensor, IEquatable<HumidityRatioSensor>
    {
        public HumidityRatioSensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:HumidityRatioSensor;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as HumidityRatioSensor);
        }

        public bool Equals(HumidityRatioSensor? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(HumidityRatioSensor? left, HumidityRatioSensor? right)
        {
            return EqualityComparer<HumidityRatioSensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(HumidityRatioSensor? left, HumidityRatioSensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}