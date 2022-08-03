using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class OffSensor : OnOffSensor, IEquatable<OffSensor>
    {
        public OffSensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:OffSensor;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as OffSensor);
        }

        public bool Equals(OffSensor? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(OffSensor? left, OffSensor? right)
        {
            return EqualityComparer<OffSensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(OffSensor? left, OffSensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}