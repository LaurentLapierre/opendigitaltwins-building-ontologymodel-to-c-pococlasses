using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class CleanAgentTank : CleanAgentEquipment, IEquatable<CleanAgentTank>
    {
        public CleanAgentTank()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:CleanAgentTank;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as CleanAgentTank);
        }

        public bool Equals(CleanAgentTank? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(CleanAgentTank? left, CleanAgentTank? right)
        {
            return EqualityComparer<CleanAgentTank?>.Default.Equals(left, right);
        }

        public static bool operator !=(CleanAgentTank? left, CleanAgentTank? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}