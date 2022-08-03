using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class HVACSolenoidValve : HVACValve, IEquatable<HVACSolenoidValve>
    {
        public HVACSolenoidValve()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:HVACSolenoidValve;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as HVACSolenoidValve);
        }

        public bool Equals(HVACSolenoidValve? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(HVACSolenoidValve? left, HVACSolenoidValve? right)
        {
            return EqualityComparer<HVACSolenoidValve?>.Default.Equals(left, right);
        }

        public static bool operator !=(HVACSolenoidValve? left, HVACSolenoidValve? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}