using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class StaticPressureSensor : PressureSensor, IEquatable<StaticPressureSensor>
    {
        public StaticPressureSensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:StaticPressureSensor;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as StaticPressureSensor);
        }

        public bool Equals(StaticPressureSensor? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(StaticPressureSensor? left, StaticPressureSensor? right)
        {
            return EqualityComparer<StaticPressureSensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(StaticPressureSensor? left, StaticPressureSensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}