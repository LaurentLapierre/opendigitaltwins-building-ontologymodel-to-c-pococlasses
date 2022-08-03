using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class LoadShedOverrideActuator : OverrideActuator, IEquatable<LoadShedOverrideActuator>
    {
        public LoadShedOverrideActuator()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:LoadShedOverrideActuator;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as LoadShedOverrideActuator);
        }

        public bool Equals(LoadShedOverrideActuator? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(LoadShedOverrideActuator? left, LoadShedOverrideActuator? right)
        {
            return EqualityComparer<LoadShedOverrideActuator?>.Default.Equals(left, right);
        }

        public static bool operator !=(LoadShedOverrideActuator? left, LoadShedOverrideActuator? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}