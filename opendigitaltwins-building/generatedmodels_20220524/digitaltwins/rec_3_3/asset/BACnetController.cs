using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class BACnetController : Controller, IEquatable<BACnetController>
    {
        public BACnetController()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:BACnetController;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as BACnetController);
        }

        public bool Equals(BACnetController? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(BACnetController? left, BACnetController? right)
        {
            return EqualityComparer<BACnetController?>.Default.Equals(left, right);
        }

        public static bool operator !=(BACnetController? left, BACnetController? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}