using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class AccessControlPanel : AccessControlEquipment, IEquatable<AccessControlPanel>
    {
        public AccessControlPanel()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:AccessControlPanel;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as AccessControlPanel);
        }

        public bool Equals(AccessControlPanel? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(AccessControlPanel? left, AccessControlPanel? right)
        {
            return EqualityComparer<AccessControlPanel?>.Default.Equals(left, right);
        }

        public static bool operator !=(AccessControlPanel? left, AccessControlPanel? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}