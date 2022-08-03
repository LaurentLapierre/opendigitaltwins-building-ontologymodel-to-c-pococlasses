using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.building
{

    public class OfficeRoom : Office, IEquatable<OfficeRoom>
    {
        public OfficeRoom()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:building:OfficeRoom;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as OfficeRoom);
        }

        public bool Equals(OfficeRoom? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(OfficeRoom? left, OfficeRoom? right)
        {
            return EqualityComparer<OfficeRoom?>.Default.Equals(left, right);
        }

        public static bool operator !=(OfficeRoom? left, OfficeRoom? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}