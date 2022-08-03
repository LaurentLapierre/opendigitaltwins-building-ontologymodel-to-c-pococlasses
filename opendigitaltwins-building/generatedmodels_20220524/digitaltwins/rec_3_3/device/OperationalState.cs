using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class OperationalState : OperationalNonOperationalState, IEquatable<OperationalState>
    {
        public OperationalState()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:OperationalState;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationalState);
        }

        public bool Equals(OperationalState? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(OperationalState? left, OperationalState? right)
        {
            return EqualityComparer<OperationalState?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationalState? left, OperationalState? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}