using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class Luminaire : LightingEquipment, IEquatable<Luminaire>
    {
        public Luminaire()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:Luminaire;2";
        [JsonPropertyName("powerInput")]
        public double? PowerInput { get; set; }
        [JsonPropertyName("mounting")]
        public LuminaireMounting? Mounting { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as Luminaire);
        }

        public bool Equals(Luminaire? other)
        {
            return other is not null && base.Equals(other) && PowerInput == other.PowerInput && Mounting == other.Mounting;
        }

        public static bool operator ==(Luminaire? left, Luminaire? right)
        {
            return EqualityComparer<Luminaire?>.Default.Equals(left, right);
        }

        public static bool operator !=(Luminaire? left, Luminaire? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), PowerInput?.GetHashCode(), Mounting?.GetHashCode());
        }
    }
}