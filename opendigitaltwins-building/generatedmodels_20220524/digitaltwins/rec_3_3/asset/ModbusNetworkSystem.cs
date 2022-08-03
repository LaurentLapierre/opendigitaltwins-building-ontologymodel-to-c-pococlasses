using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class ModbusNetworkSystem : ControlsSystem, IEquatable<ModbusNetworkSystem>
    {
        public ModbusNetworkSystem()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:ModbusNetworkSystem;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as ModbusNetworkSystem);
        }

        public bool Equals(ModbusNetworkSystem? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(ModbusNetworkSystem? left, ModbusNetworkSystem? right)
        {
            return EqualityComparer<ModbusNetworkSystem?>.Default.Equals(left, right);
        }

        public static bool operator !=(ModbusNetworkSystem? left, ModbusNetworkSystem? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}