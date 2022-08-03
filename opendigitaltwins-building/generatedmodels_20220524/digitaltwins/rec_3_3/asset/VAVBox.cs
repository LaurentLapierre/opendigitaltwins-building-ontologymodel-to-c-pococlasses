using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class VAVBox : TerminalUnit, IEquatable<VAVBox>
    {
        public VAVBox()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:VAVBox;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as VAVBox);
        }

        public bool Equals(VAVBox? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(VAVBox? left, VAVBox? right)
        {
            return EqualityComparer<VAVBox?>.Default.Equals(left, right);
        }

        public static bool operator !=(VAVBox? left, VAVBox? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}