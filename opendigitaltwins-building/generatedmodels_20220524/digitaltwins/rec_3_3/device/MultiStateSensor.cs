using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class MultiStateSensor : StateSensor, IEquatable<MultiStateSensor>
    {
        public MultiStateSensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:MultiStateSensor;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as MultiStateSensor);
        }

        public bool Equals(MultiStateSensor? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(MultiStateSensor? left, MultiStateSensor? right)
        {
            return EqualityComparer<MultiStateSensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(MultiStateSensor? left, MultiStateSensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}