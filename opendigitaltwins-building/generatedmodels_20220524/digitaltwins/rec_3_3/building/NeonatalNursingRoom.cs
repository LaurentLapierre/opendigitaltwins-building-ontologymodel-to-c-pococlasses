using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.building
{

    public class NeonatalNursingRoom : HealthcareRoom, IEquatable<NeonatalNursingRoom>
    {
        public NeonatalNursingRoom()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:building:NeonatalNursingRoom;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as NeonatalNursingRoom);
        }

        public bool Equals(NeonatalNursingRoom? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(NeonatalNursingRoom? left, NeonatalNursingRoom? right)
        {
            return EqualityComparer<NeonatalNursingRoom?>.Default.Equals(left, right);
        }

        public static bool operator !=(NeonatalNursingRoom? left, NeonatalNursingRoom? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}