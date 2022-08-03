using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class Boiler : PlumbingEquipment, IEquatable<Boiler>
    {
        public Boiler()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:Boiler;1";
        [JsonPropertyName("type")]
        public BoilerType? Type { get; set; }
        [JsonPropertyName("tankCapacity")]
        public double? TankCapacity { get; set; }
        [JsonPropertyName("powerOutput")]
        public double? PowerOutput { get; set; }
        [JsonPropertyName("powerInput")]
        public double? PowerInput { get; set; }
        [JsonPropertyName("medium")]
        public BoilerMedium? Medium { get; set; }
        [JsonPropertyName("recovery100FRise")]
        public int? Recovery100FRise { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as Boiler);
        }

        public bool Equals(Boiler? other)
        {
            return other is not null && base.Equals(other) && Type == other.Type && TankCapacity == other.TankCapacity && PowerOutput == other.PowerOutput && PowerInput == other.PowerInput && Medium == other.Medium && Recovery100FRise == other.Recovery100FRise;
        }

        public static bool operator ==(Boiler? left, Boiler? right)
        {
            return EqualityComparer<Boiler?>.Default.Equals(left, right);
        }

        public static bool operator !=(Boiler? left, Boiler? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Type?.GetHashCode(), TankCapacity?.GetHashCode(), PowerOutput?.GetHashCode(), PowerInput?.GetHashCode(), Medium?.GetHashCode(), Recovery100FRise?.GetHashCode());
        }
    }
}