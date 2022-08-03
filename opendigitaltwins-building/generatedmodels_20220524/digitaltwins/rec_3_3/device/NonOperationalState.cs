using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class NonOperationalState : OperationalNonOperationalState, IEquatable<NonOperationalState>
    {
        public NonOperationalState()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:NonOperationalState;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as NonOperationalState);
        }

        public bool Equals(NonOperationalState? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(NonOperationalState? left, NonOperationalState? right)
        {
            return EqualityComparer<NonOperationalState?>.Default.Equals(left, right);
        }

        public static bool operator !=(NonOperationalState? left, NonOperationalState? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}