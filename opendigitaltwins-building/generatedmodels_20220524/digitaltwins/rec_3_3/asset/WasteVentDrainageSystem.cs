using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class WasteVentDrainageSystem : DrainageSystem, IEquatable<WasteVentDrainageSystem>
    {
        public WasteVentDrainageSystem()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:WasteVentDrainageSystem;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as WasteVentDrainageSystem);
        }

        public bool Equals(WasteVentDrainageSystem? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(WasteVentDrainageSystem? left, WasteVentDrainageSystem? right)
        {
            return EqualityComparer<WasteVentDrainageSystem?>.Default.Equals(left, right);
        }

        public static bool operator !=(WasteVentDrainageSystem? left, WasteVentDrainageSystem? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}