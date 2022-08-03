using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class ElectricalEnergySensor : EnergySensor, IEquatable<ElectricalEnergySensor>
    {
        public ElectricalEnergySensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:ElectricalEnergySensor;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as ElectricalEnergySensor);
        }

        public bool Equals(ElectricalEnergySensor? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(ElectricalEnergySensor? left, ElectricalEnergySensor? right)
        {
            return EqualityComparer<ElectricalEnergySensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(ElectricalEnergySensor? left, ElectricalEnergySensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}