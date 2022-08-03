using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.asset.relationship.icthardware;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class ICTHardware : ICTEquipment, IEquatable<ICTHardware>
    {
        public ICTHardware()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:ICTHardware;1";
        [JsonIgnore]
        public ICTHardwareMountedInRackRelationshipCollection MountedInRack { get; set; } = new ICTHardwareMountedInRackRelationshipCollection();
        public override bool Equals(object? obj)
        {
            return Equals(obj as ICTHardware);
        }

        public bool Equals(ICTHardware? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(ICTHardware? left, ICTHardware? right)
        {
            return EqualityComparer<ICTHardware?>.Default.Equals(left, right);
        }

        public static bool operator !=(ICTHardware? left, ICTHardware? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}