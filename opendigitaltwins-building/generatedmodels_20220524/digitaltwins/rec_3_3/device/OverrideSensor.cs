using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class OverrideSensor : DefaultOverrideSensor, IEquatable<OverrideSensor>
    {
        public OverrideSensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:OverrideSensor;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as OverrideSensor);
        }

        public bool Equals(OverrideSensor? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(OverrideSensor? left, OverrideSensor? right)
        {
            return EqualityComparer<OverrideSensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(OverrideSensor? left, OverrideSensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}