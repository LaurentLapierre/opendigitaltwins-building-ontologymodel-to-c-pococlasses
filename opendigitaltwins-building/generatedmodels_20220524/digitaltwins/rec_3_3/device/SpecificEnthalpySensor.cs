using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class SpecificEnthalpySensor : EnthalpySensor, IEquatable<SpecificEnthalpySensor>
    {
        public SpecificEnthalpySensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:SpecificEnthalpySensor;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as SpecificEnthalpySensor);
        }

        public bool Equals(SpecificEnthalpySensor? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(SpecificEnthalpySensor? left, SpecificEnthalpySensor? right)
        {
            return EqualityComparer<SpecificEnthalpySensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(SpecificEnthalpySensor? left, SpecificEnthalpySensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}