using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.core
{

    public class Zone : Space, IEquatable<Zone>
    {
        public Zone()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:core:Zone;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as Zone);
        }

        public bool Equals(Zone? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(Zone? left, Zone? right)
        {
            return EqualityComparer<Zone?>.Default.Equals(left, right);
        }

        public static bool operator !=(Zone? left, Zone? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}