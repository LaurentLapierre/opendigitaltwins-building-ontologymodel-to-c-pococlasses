using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.core
{

    public class LogicalGateway : LogicalDevice, IEquatable<LogicalGateway>
    {
        public LogicalGateway()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:core:LogicalGateway;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as LogicalGateway);
        }

        public bool Equals(LogicalGateway? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(LogicalGateway? left, LogicalGateway? right)
        {
            return EqualityComparer<LogicalGateway?>.Default.Equals(left, right);
        }

        public static bool operator !=(LogicalGateway? left, LogicalGateway? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}