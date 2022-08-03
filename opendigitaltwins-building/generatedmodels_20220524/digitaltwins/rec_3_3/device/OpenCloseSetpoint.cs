using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class OpenCloseSetpoint : BinarySetpoint, IEquatable<OpenCloseSetpoint>
    {
        public OpenCloseSetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:OpenCloseSetpoint;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as OpenCloseSetpoint);
        }

        public bool Equals(OpenCloseSetpoint? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(OpenCloseSetpoint? left, OpenCloseSetpoint? right)
        {
            return EqualityComparer<OpenCloseSetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(OpenCloseSetpoint? left, OpenCloseSetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}