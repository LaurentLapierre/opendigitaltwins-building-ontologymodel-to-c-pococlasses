using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.core;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class StateSetpoint : Setpoint, IEquatable<StateSetpoint>
    {
        public StateSetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:StateSetpoint;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as StateSetpoint);
        }

        public bool Equals(StateSetpoint? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(StateSetpoint? left, StateSetpoint? right)
        {
            return EqualityComparer<StateSetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(StateSetpoint? left, StateSetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}