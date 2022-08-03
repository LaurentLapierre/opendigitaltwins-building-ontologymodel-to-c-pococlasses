using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class OpenSensor : OpenCloseSensor, IEquatable<OpenSensor>
    {
        public OpenSensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:OpenSensor;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as OpenSensor);
        }

        public bool Equals(OpenSensor? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(OpenSensor? left, OpenSensor? right)
        {
            return EqualityComparer<OpenSensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(OpenSensor? left, OpenSensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}