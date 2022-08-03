using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class PreActionTank : PreActionEquipment, IEquatable<PreActionTank>
    {
        public PreActionTank()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:PreActionTank;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as PreActionTank);
        }

        public bool Equals(PreActionTank? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(PreActionTank? left, PreActionTank? right)
        {
            return EqualityComparer<PreActionTank?>.Default.Equals(left, right);
        }

        public static bool operator !=(PreActionTank? left, PreActionTank? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}