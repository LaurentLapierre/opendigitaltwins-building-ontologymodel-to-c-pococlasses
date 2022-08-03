using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class CleanAgentEquipment : FireSuppressionEquipment, IEquatable<CleanAgentEquipment>
    {
        public CleanAgentEquipment()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:CleanAgentEquipment;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as CleanAgentEquipment);
        }

        public bool Equals(CleanAgentEquipment? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(CleanAgentEquipment? left, CleanAgentEquipment? right)
        {
            return EqualityComparer<CleanAgentEquipment?>.Default.Equals(left, right);
        }

        public static bool operator !=(CleanAgentEquipment? left, CleanAgentEquipment? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}