using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class VelocitySensor : QuantitySensor, IEquatable<VelocitySensor>
    {
        public VelocitySensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:VelocitySensor;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as VelocitySensor);
        }

        public bool Equals(VelocitySensor? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(VelocitySensor? left, VelocitySensor? right)
        {
            return EqualityComparer<VelocitySensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(VelocitySensor? left, VelocitySensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}