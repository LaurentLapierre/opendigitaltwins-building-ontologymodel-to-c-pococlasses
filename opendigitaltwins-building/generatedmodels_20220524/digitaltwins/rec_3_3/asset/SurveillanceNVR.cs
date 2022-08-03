using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class SurveillanceNVR : VideoSurveillanceEquipment, IEquatable<SurveillanceNVR>
    {
        public SurveillanceNVR()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:SurveillanceNVR;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as SurveillanceNVR);
        }

        public bool Equals(SurveillanceNVR? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(SurveillanceNVR? left, SurveillanceNVR? right)
        {
            return EqualityComparer<SurveillanceNVR?>.Default.Equals(left, right);
        }

        public static bool operator !=(SurveillanceNVR? left, SurveillanceNVR? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}