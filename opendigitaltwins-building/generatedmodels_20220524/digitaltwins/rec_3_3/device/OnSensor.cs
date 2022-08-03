using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class OnSensor : OnOffSensor, IEquatable<OnSensor>
    {
        public OnSensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:OnSensor;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as OnSensor);
        }

        public bool Equals(OnSensor? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(OnSensor? left, OnSensor? right)
        {
            return EqualityComparer<OnSensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(OnSensor? left, OnSensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}