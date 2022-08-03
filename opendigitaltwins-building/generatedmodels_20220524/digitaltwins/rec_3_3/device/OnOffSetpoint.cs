using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class OnOffSetpoint : BinarySetpoint, IEquatable<OnOffSetpoint>
    {
        public OnOffSetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:OnOffSetpoint;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as OnOffSetpoint);
        }

        public bool Equals(OnOffSetpoint? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(OnOffSetpoint? left, OnOffSetpoint? right)
        {
            return EqualityComparer<OnOffSetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(OnOffSetpoint? left, OnOffSetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}