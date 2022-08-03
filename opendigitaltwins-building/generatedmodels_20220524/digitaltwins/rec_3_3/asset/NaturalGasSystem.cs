using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class NaturalGasSystem : GasSystem, IEquatable<NaturalGasSystem>
    {
        public NaturalGasSystem()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:NaturalGasSystem;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as NaturalGasSystem);
        }

        public bool Equals(NaturalGasSystem? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(NaturalGasSystem? left, NaturalGasSystem? right)
        {
            return EqualityComparer<NaturalGasSystem?>.Default.Equals(left, right);
        }

        public static bool operator !=(NaturalGasSystem? left, NaturalGasSystem? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}