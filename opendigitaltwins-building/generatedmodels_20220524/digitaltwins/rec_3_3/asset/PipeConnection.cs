using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class PipeConnection : Component, IEquatable<PipeConnection>
    {
        public PipeConnection()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:PipeConnection;1";
        [JsonPropertyName("outsideDiameter")]
        public double? OutsideDiameter { get; set; }
        [JsonPropertyName("nominalDiameter")]
        public double? NominalDiameter { get; set; }
        [JsonPropertyName("insideDiameter")]
        public double? InsideDiameter { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as PipeConnection);
        }

        public bool Equals(PipeConnection? other)
        {
            return other is not null && base.Equals(other) && OutsideDiameter == other.OutsideDiameter && NominalDiameter == other.NominalDiameter && InsideDiameter == other.InsideDiameter;
        }

        public static bool operator ==(PipeConnection? left, PipeConnection? right)
        {
            return EqualityComparer<PipeConnection?>.Default.Equals(left, right);
        }

        public static bool operator !=(PipeConnection? left, PipeConnection? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), OutsideDiameter?.GetHashCode(), NominalDiameter?.GetHashCode(), InsideDiameter?.GetHashCode());
        }
    }
}