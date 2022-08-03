using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class SmokeSensor : BinarySensor, IEquatable<SmokeSensor>
    {
        public SmokeSensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:SmokeSensor;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as SmokeSensor);
        }

        public bool Equals(SmokeSensor? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(SmokeSensor? left, SmokeSensor? right)
        {
            return EqualityComparer<SmokeSensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(SmokeSensor? left, SmokeSensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}