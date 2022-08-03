using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.core;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class ArchitecturalAsset : Asset, IEquatable<ArchitecturalAsset>
    {
        public ArchitecturalAsset()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:ArchitecturalAsset;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as ArchitecturalAsset);
        }

        public bool Equals(ArchitecturalAsset? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(ArchitecturalAsset? left, ArchitecturalAsset? right)
        {
            return EqualityComparer<ArchitecturalAsset?>.Default.Equals(left, right);
        }

        public static bool operator !=(ArchitecturalAsset? left, ArchitecturalAsset? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}