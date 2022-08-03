using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class LoadShedOverrideSensor : OverrideSensor, IEquatable<LoadShedOverrideSensor>
    {
        public LoadShedOverrideSensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:LoadShedOverrideSensor;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as LoadShedOverrideSensor);
        }

        public bool Equals(LoadShedOverrideSensor? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(LoadShedOverrideSensor? left, LoadShedOverrideSensor? right)
        {
            return EqualityComparer<LoadShedOverrideSensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(LoadShedOverrideSensor? left, LoadShedOverrideSensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}