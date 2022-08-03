using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class IntercomEntry : AccessControlEquipment, IEquatable<IntercomEntry>
    {
        public IntercomEntry()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:IntercomEntry;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as IntercomEntry);
        }

        public bool Equals(IntercomEntry? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(IntercomEntry? left, IntercomEntry? right)
        {
            return EqualityComparer<IntercomEntry?>.Default.Equals(left, right);
        }

        public static bool operator !=(IntercomEntry? left, IntercomEntry? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}