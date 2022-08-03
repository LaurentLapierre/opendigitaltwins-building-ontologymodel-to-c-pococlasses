using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class EjectorPump : PlumbingPump, IEquatable<EjectorPump>
    {
        public EjectorPump()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:EjectorPump;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as EjectorPump);
        }

        public bool Equals(EjectorPump? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(EjectorPump? left, EjectorPump? right)
        {
            return EqualityComparer<EjectorPump?>.Default.Equals(left, right);
        }

        public static bool operator !=(EjectorPump? left, EjectorPump? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}