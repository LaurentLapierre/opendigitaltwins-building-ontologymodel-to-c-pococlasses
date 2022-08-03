using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class OnSetpoint : OnOffSetpoint, IEquatable<OnSetpoint>
    {
        public OnSetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:OnSetpoint;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as OnSetpoint);
        }

        public bool Equals(OnSetpoint? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(OnSetpoint? left, OnSetpoint? right)
        {
            return EqualityComparer<OnSetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(OnSetpoint? left, OnSetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}