using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class OpenCloseSensor : BinarySensor, IEquatable<OpenCloseSensor>
    {
        public OpenCloseSensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:OpenCloseSensor;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as OpenCloseSensor);
        }

        public bool Equals(OpenCloseSensor? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(OpenCloseSensor? left, OpenCloseSensor? right)
        {
            return EqualityComparer<OpenCloseSensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(OpenCloseSensor? left, OpenCloseSensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}