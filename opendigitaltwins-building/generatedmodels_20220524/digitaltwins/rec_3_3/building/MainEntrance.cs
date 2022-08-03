using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.building
{

    public class MainEntrance : Entrance, IEquatable<MainEntrance>
    {
        public MainEntrance()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:building:MainEntrance;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as MainEntrance);
        }

        public bool Equals(MainEntrance? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(MainEntrance? left, MainEntrance? right)
        {
            return EqualityComparer<MainEntrance?>.Default.Equals(left, right);
        }

        public static bool operator !=(MainEntrance? left, MainEntrance? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}