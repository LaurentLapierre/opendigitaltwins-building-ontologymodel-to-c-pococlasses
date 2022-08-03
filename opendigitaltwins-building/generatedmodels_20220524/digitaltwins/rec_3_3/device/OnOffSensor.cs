using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class OnOffSensor : BinarySensor, IEquatable<OnOffSensor>
    {
        public OnOffSensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:OnOffSensor;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as OnOffSensor);
        }

        public bool Equals(OnOffSensor? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(OnOffSensor? left, OnOffSensor? right)
        {
            return EqualityComparer<OnOffSensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(OnOffSensor? left, OnOffSensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}