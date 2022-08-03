using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class BinarySetpoint : StateSetpoint, IEquatable<BinarySetpoint>
    {
        public BinarySetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:BinarySetpoint;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as BinarySetpoint);
        }

        public bool Equals(BinarySetpoint? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(BinarySetpoint? left, BinarySetpoint? right)
        {
            return EqualityComparer<BinarySetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(BinarySetpoint? left, BinarySetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}