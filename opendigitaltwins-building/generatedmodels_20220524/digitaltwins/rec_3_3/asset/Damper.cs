using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class Damper : HVACEquipment, IEquatable<Damper>
    {
        public Damper()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:Damper;1";
        [JsonPropertyName("service")]
        public DamperService? Service { get; set; }
        [JsonPropertyName("leakageClass")]
        public DamperLeakageClass? LeakageClass { get; set; }
        [JsonPropertyName("bladeType")]
        public DamperBladeType? BladeType { get; set; }
        [JsonPropertyName("ductInlet")]
        public DuctConnection? DuctInlet { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as Damper);
        }

        public bool Equals(Damper? other)
        {
            return other is not null && base.Equals(other) && Service == other.Service && LeakageClass == other.LeakageClass && BladeType == other.BladeType && DuctInlet == other.DuctInlet;
        }

        public static bool operator ==(Damper? left, Damper? right)
        {
            return EqualityComparer<Damper?>.Default.Equals(left, right);
        }

        public static bool operator !=(Damper? left, Damper? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Service?.GetHashCode(), LeakageClass?.GetHashCode(), BladeType?.GetHashCode(), DuctInlet?.GetHashCode());
        }
    }
}