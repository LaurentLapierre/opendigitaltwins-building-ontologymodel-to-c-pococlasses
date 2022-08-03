using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class FaultResetSensor : ResetSensor, IEquatable<FaultResetSensor>
    {
        public FaultResetSensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:FaultResetSensor;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as FaultResetSensor);
        }

        public bool Equals(FaultResetSensor? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(FaultResetSensor? left, FaultResetSensor? right)
        {
            return EqualityComparer<FaultResetSensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(FaultResetSensor? left, FaultResetSensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}