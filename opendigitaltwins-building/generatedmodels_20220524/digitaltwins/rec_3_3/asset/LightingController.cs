using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class LightingController : LightingEquipment, IEquatable<LightingController>
    {
        public LightingController()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:LightingController;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as LightingController);
        }

        public bool Equals(LightingController? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(LightingController? left, LightingController? right)
        {
            return EqualityComparer<LightingController?>.Default.Equals(left, right);
        }

        public static bool operator !=(LightingController? left, LightingController? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}