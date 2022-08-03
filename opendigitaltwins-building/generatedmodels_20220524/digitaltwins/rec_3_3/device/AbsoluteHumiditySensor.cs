using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class AbsoluteHumiditySensor : HumiditySensor, IEquatable<AbsoluteHumiditySensor>
    {
        public AbsoluteHumiditySensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:AbsoluteHumiditySensor;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as AbsoluteHumiditySensor);
        }

        public bool Equals(AbsoluteHumiditySensor? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(AbsoluteHumiditySensor? left, AbsoluteHumiditySensor? right)
        {
            return EqualityComparer<AbsoluteHumiditySensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(AbsoluteHumiditySensor? left, AbsoluteHumiditySensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}