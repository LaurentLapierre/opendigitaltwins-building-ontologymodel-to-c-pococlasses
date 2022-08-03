using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.building
{

    public class SmallStudyRoom : EducationalRoom, IEquatable<SmallStudyRoom>
    {
        public SmallStudyRoom()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:building:SmallStudyRoom;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as SmallStudyRoom);
        }

        public bool Equals(SmallStudyRoom? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(SmallStudyRoom? left, SmallStudyRoom? right)
        {
            return EqualityComparer<SmallStudyRoom?>.Default.Equals(left, right);
        }

        public static bool operator !=(SmallStudyRoom? left, SmallStudyRoom? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}