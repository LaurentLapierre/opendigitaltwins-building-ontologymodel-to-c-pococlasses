using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class ControlsSystem : System, IEquatable<ControlsSystem>
    {
        public ControlsSystem()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:ControlsSystem;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as ControlsSystem);
        }

        public bool Equals(ControlsSystem? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(ControlsSystem? left, ControlsSystem? right)
        {
            return EqualityComparer<ControlsSystem?>.Default.Equals(left, right);
        }

        public static bool operator !=(ControlsSystem? left, ControlsSystem? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}