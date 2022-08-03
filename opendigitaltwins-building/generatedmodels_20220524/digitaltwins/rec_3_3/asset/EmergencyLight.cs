using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class EmergencyLight : SafetyLighting, IEquatable<EmergencyLight>
    {
        public EmergencyLight()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:EmergencyLight;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as EmergencyLight);
        }

        public bool Equals(EmergencyLight? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(EmergencyLight? left, EmergencyLight? right)
        {
            return EqualityComparer<EmergencyLight?>.Default.Equals(left, right);
        }

        public static bool operator !=(EmergencyLight? left, EmergencyLight? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}