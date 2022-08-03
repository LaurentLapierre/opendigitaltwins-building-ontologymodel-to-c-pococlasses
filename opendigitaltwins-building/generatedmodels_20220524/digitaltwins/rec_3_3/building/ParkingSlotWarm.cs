using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.building
{

    public class ParkingSlotWarm : Garage, IEquatable<ParkingSlotWarm>
    {
        public ParkingSlotWarm()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:building:ParkingSlotWarm;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as ParkingSlotWarm);
        }

        public bool Equals(ParkingSlotWarm? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(ParkingSlotWarm? left, ParkingSlotWarm? right)
        {
            return EqualityComparer<ParkingSlotWarm?>.Default.Equals(left, right);
        }

        public static bool operator !=(ParkingSlotWarm? left, ParkingSlotWarm? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}