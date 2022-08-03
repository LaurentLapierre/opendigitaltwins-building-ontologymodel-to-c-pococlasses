using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class StartSensor : StartStopSensor, IEquatable<StartSensor>
    {
        public StartSensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:StartSensor;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as StartSensor);
        }

        public bool Equals(StartSensor? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(StartSensor? left, StartSensor? right)
        {
            return EqualityComparer<StartSensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(StartSensor? left, StartSensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}