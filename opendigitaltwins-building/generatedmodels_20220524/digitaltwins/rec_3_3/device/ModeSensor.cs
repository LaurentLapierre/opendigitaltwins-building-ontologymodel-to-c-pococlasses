using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class ModeSensor : MultiStateSensor, IEquatable<ModeSensor>
    {
        public ModeSensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:ModeSensor;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as ModeSensor);
        }

        public bool Equals(ModeSensor? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(ModeSensor? left, ModeSensor? right)
        {
            return EqualityComparer<ModeSensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(ModeSensor? left, ModeSensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}