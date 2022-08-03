using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class PlumbingSolenoidValve : PlumbingValve, IEquatable<PlumbingSolenoidValve>
    {
        public PlumbingSolenoidValve()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:PlumbingSolenoidValve;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as PlumbingSolenoidValve);
        }

        public bool Equals(PlumbingSolenoidValve? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(PlumbingSolenoidValve? left, PlumbingSolenoidValve? right)
        {
            return EqualityComparer<PlumbingSolenoidValve?>.Default.Equals(left, right);
        }

        public static bool operator !=(PlumbingSolenoidValve? left, PlumbingSolenoidValve? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}