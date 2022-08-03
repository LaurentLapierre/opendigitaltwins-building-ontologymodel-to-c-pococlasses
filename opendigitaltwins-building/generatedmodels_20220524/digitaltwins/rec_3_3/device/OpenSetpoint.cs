using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class OpenSetpoint : OpenCloseSetpoint, IEquatable<OpenSetpoint>
    {
        public OpenSetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:OpenSetpoint;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as OpenSetpoint);
        }

        public bool Equals(OpenSetpoint? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(OpenSetpoint? left, OpenSetpoint? right)
        {
            return EqualityComparer<OpenSetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(OpenSetpoint? left, OpenSetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}