using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class ConditionState : MultiState, IEquatable<ConditionState>
    {
        public ConditionState()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:ConditionState;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as ConditionState);
        }

        public bool Equals(ConditionState? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(ConditionState? left, ConditionState? right)
        {
            return EqualityComparer<ConditionState?>.Default.Equals(left, right);
        }

        public static bool operator !=(ConditionState? left, ConditionState? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}