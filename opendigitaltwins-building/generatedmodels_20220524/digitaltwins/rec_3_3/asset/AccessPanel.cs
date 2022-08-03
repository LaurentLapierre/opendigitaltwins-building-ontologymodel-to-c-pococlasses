using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class AccessPanel : BarrierAsset, IEquatable<AccessPanel>
    {
        public AccessPanel()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:AccessPanel;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as AccessPanel);
        }

        public bool Equals(AccessPanel? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(AccessPanel? left, AccessPanel? right)
        {
            return EqualityComparer<AccessPanel?>.Default.Equals(left, right);
        }

        public static bool operator !=(AccessPanel? left, AccessPanel? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}