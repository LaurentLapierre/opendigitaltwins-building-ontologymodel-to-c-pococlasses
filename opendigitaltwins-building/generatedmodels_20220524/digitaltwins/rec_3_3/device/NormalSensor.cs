using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class NormalSensor : NormalFaultSensor, IEquatable<NormalSensor>
    {
        public NormalSensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:NormalSensor;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as NormalSensor);
        }

        public bool Equals(NormalSensor? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(NormalSensor? left, NormalSensor? right)
        {
            return EqualityComparer<NormalSensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(NormalSensor? left, NormalSensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}