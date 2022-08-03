using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class AudioVisualEquipment : ICTEquipment, IEquatable<AudioVisualEquipment>
    {
        public AudioVisualEquipment()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:AudioVisualEquipment;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as AudioVisualEquipment);
        }

        public bool Equals(AudioVisualEquipment? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(AudioVisualEquipment? left, AudioVisualEquipment? right)
        {
            return EqualityComparer<AudioVisualEquipment?>.Default.Equals(left, right);
        }

        public static bool operator !=(AudioVisualEquipment? left, AudioVisualEquipment? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}