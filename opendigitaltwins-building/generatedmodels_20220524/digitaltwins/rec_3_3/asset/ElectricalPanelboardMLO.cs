using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class ElectricalPanelboardMLO : ElectricalPanelboard, IEquatable<ElectricalPanelboardMLO>
    {
        public ElectricalPanelboardMLO()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:ElectricalPanelboardMLO;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as ElectricalPanelboardMLO);
        }

        public bool Equals(ElectricalPanelboardMLO? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(ElectricalPanelboardMLO? left, ElectricalPanelboardMLO? right)
        {
            return EqualityComparer<ElectricalPanelboardMLO?>.Default.Equals(left, right);
        }

        public static bool operator !=(ElectricalPanelboardMLO? left, ElectricalPanelboardMLO? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}