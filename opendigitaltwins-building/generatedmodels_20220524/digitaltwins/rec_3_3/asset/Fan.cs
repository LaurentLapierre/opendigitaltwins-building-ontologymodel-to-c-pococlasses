using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class Fan : Component, IEquatable<Fan>
    {
        public Fan()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:Fan;1";
        [JsonPropertyName("nominalExternalStaticPressure")]
        public double? NominalExternalStaticPressure { get; set; }
        [JsonPropertyName("nominalAirflow")]
        public double? NominalAirflow { get; set; }
        [JsonPropertyName("motorPower")]
        public double? MotorPower { get; set; }
        [JsonPropertyName("minAirflowRating")]
        public double? MinAirflowRating { get; set; }
        [JsonPropertyName("maxAirflowRating")]
        public double? MaxAirflowRating { get; set; }
        [JsonPropertyName("driveType")]
        public FanDriveType? DriveType { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as Fan);
        }

        public bool Equals(Fan? other)
        {
            return other is not null && base.Equals(other) && NominalExternalStaticPressure == other.NominalExternalStaticPressure && NominalAirflow == other.NominalAirflow && MotorPower == other.MotorPower && MinAirflowRating == other.MinAirflowRating && MaxAirflowRating == other.MaxAirflowRating && DriveType == other.DriveType;
        }

        public static bool operator ==(Fan? left, Fan? right)
        {
            return EqualityComparer<Fan?>.Default.Equals(left, right);
        }

        public static bool operator !=(Fan? left, Fan? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), NominalExternalStaticPressure?.GetHashCode(), NominalAirflow?.GetHashCode(), MotorPower?.GetHashCode(), MinAirflowRating?.GetHashCode(), MaxAirflowRating?.GetHashCode(), DriveType?.GetHashCode());
        }
    }
}