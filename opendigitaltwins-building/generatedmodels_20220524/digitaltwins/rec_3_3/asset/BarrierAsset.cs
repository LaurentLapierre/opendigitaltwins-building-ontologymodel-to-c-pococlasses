using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.asset.relationship.barrierasset;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class BarrierAsset : ArchitecturalAsset, IEquatable<BarrierAsset>
    {
        public BarrierAsset()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:BarrierAsset;1";
        [JsonPropertyName("width")]
        public double? Width { get; set; }
        [JsonPropertyName("thickness")]
        public double? Thickness { get; set; }
        [JsonPropertyName("service")]
        public BarrierAssetService? Service { get; set; }
        [JsonPropertyName("material")]
        public string? Material { get; set; }
        [JsonPropertyName("height")]
        public double? Height { get; set; }
        [JsonPropertyName("frameMaterial")]
        public string? FrameMaterial { get; set; }
        [JsonPropertyName("fireRating")]
        public double? FireRating { get; set; }
        [JsonIgnore]
        public BarrierAssetToSpaceRelationshipCollection ToSpace { get; set; } = new BarrierAssetToSpaceRelationshipCollection();
        [JsonIgnore]
        public BarrierAssetFromSpaceRelationshipCollection FromSpace { get; set; } = new BarrierAssetFromSpaceRelationshipCollection();
        public override bool Equals(object? obj)
        {
            return Equals(obj as BarrierAsset);
        }

        public bool Equals(BarrierAsset? other)
        {
            return other is not null && base.Equals(other) && Width == other.Width && Thickness == other.Thickness && Service == other.Service && Material == other.Material && Height == other.Height && FrameMaterial == other.FrameMaterial && FireRating == other.FireRating;
        }

        public static bool operator ==(BarrierAsset? left, BarrierAsset? right)
        {
            return EqualityComparer<BarrierAsset?>.Default.Equals(left, right);
        }

        public static bool operator !=(BarrierAsset? left, BarrierAsset? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Width?.GetHashCode(), Thickness?.GetHashCode(), Service?.GetHashCode(), Material?.GetHashCode(), Height?.GetHashCode(), FrameMaterial?.GetHashCode(), FireRating?.GetHashCode());
        }
    }
}