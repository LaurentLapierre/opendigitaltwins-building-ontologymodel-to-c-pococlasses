using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.core
{

    public class LogicalController : LogicalDevice, IEquatable<LogicalController>
    {
        public LogicalController()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:core:LogicalController;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as LogicalController);
        }

        public bool Equals(LogicalController? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(LogicalController? left, LogicalController? right)
        {
            return EqualityComparer<LogicalController?>.Default.Equals(left, right);
        }

        public static bool operator !=(LogicalController? left, LogicalController? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}