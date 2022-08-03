using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.building
{

    public class TreatmentWaitingRoom : TreatmentRoom, IEquatable<TreatmentWaitingRoom>
    {
        public TreatmentWaitingRoom()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:building:TreatmentWaitingRoom;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as TreatmentWaitingRoom);
        }

        public bool Equals(TreatmentWaitingRoom? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(TreatmentWaitingRoom? left, TreatmentWaitingRoom? right)
        {
            return EqualityComparer<TreatmentWaitingRoom?>.Default.Equals(left, right);
        }

        public static bool operator !=(TreatmentWaitingRoom? left, TreatmentWaitingRoom? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}