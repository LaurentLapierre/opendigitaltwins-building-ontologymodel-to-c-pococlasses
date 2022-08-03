using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class RelativeHumiditySensor : HumiditySensor, IEquatable<RelativeHumiditySensor>
    {
        public RelativeHumiditySensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:RelativeHumiditySensor;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as RelativeHumiditySensor);
        }

        public bool Equals(RelativeHumiditySensor? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(RelativeHumiditySensor? left, RelativeHumiditySensor? right)
        {
            return EqualityComparer<RelativeHumiditySensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(RelativeHumiditySensor? left, RelativeHumiditySensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}