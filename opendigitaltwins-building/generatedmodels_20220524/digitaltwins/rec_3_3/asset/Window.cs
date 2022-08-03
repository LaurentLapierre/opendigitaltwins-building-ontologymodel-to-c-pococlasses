using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class Window : BarrierAsset, IEquatable<Window>
    {
        public Window()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:Window;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as Window);
        }

        public bool Equals(Window? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(Window? left, Window? right)
        {
            return EqualityComparer<Window?>.Default.Equals(left, right);
        }

        public static bool operator !=(Window? left, Window? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}