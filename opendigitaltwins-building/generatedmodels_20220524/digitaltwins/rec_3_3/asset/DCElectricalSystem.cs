using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class DCElectricalSystem : ElectricalSystem, IEquatable<DCElectricalSystem>
    {
        public DCElectricalSystem()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:DCElectricalSystem;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as DCElectricalSystem);
        }

        public bool Equals(DCElectricalSystem? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(DCElectricalSystem? left, DCElectricalSystem? right)
        {
            return EqualityComparer<DCElectricalSystem?>.Default.Equals(left, right);
        }

        public static bool operator !=(DCElectricalSystem? left, DCElectricalSystem? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}