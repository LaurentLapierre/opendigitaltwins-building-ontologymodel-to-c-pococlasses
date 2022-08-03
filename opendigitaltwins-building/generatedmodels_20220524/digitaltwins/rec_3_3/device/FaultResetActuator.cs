using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class FaultResetActuator : ResetActuator, IEquatable<FaultResetActuator>
    {
        public FaultResetActuator()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:FaultResetActuator;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as FaultResetActuator);
        }

        public bool Equals(FaultResetActuator? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(FaultResetActuator? left, FaultResetActuator? right)
        {
            return EqualityComparer<FaultResetActuator?>.Default.Equals(left, right);
        }

        public static bool operator !=(FaultResetActuator? left, FaultResetActuator? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}