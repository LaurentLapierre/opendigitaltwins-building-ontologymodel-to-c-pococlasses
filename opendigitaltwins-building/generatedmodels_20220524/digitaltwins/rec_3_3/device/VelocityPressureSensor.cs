using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class VelocityPressureSensor : PressureSensor, IEquatable<VelocityPressureSensor>
    {
        public VelocityPressureSensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:VelocityPressureSensor;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as VelocityPressureSensor);
        }

        public bool Equals(VelocityPressureSensor? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(VelocityPressureSensor? left, VelocityPressureSensor? right)
        {
            return EqualityComparer<VelocityPressureSensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(VelocityPressureSensor? left, VelocityPressureSensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}