using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.core
{

    public class LogicalServer : LogicalDevice, IEquatable<LogicalServer>
    {
        public LogicalServer()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:core:LogicalServer;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as LogicalServer);
        }

        public bool Equals(LogicalServer? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(LogicalServer? left, LogicalServer? right)
        {
            return EqualityComparer<LogicalServer?>.Default.Equals(left, right);
        }

        public static bool operator !=(LogicalServer? left, LogicalServer? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}