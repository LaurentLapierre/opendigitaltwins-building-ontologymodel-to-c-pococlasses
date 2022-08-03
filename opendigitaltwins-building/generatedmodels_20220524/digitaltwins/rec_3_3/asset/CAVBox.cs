using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class CAVBox : TerminalUnit, IEquatable<CAVBox>
    {
        public CAVBox()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:CAVBox;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as CAVBox);
        }

        public bool Equals(CAVBox? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(CAVBox? left, CAVBox? right)
        {
            return EqualityComparer<CAVBox?>.Default.Equals(left, right);
        }

        public static bool operator !=(CAVBox? left, CAVBox? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}