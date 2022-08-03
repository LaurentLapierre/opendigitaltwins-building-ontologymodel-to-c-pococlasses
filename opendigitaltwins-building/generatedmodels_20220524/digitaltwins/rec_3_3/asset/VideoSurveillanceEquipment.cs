using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class VideoSurveillanceEquipment : SecurityEquipment, IEquatable<VideoSurveillanceEquipment>
    {
        public VideoSurveillanceEquipment()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:VideoSurveillanceEquipment;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as VideoSurveillanceEquipment);
        }

        public bool Equals(VideoSurveillanceEquipment? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(VideoSurveillanceEquipment? left, VideoSurveillanceEquipment? right)
        {
            return EqualityComparer<VideoSurveillanceEquipment?>.Default.Equals(left, right);
        }

        public static bool operator !=(VideoSurveillanceEquipment? left, VideoSurveillanceEquipment? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}