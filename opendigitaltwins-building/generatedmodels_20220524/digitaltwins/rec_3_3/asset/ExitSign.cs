using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class ExitSign : SafetyLighting, IEquatable<ExitSign>
    {
        public ExitSign()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:ExitSign;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as ExitSign);
        }

        public bool Equals(ExitSign? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(ExitSign? left, ExitSign? right)
        {
            return EqualityComparer<ExitSign?>.Default.Equals(left, right);
        }

        public static bool operator !=(ExitSign? left, ExitSign? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}