using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class ModbusController : Controller, IEquatable<ModbusController>
    {
        public ModbusController()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:ModbusController;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as ModbusController);
        }

        public bool Equals(ModbusController? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(ModbusController? left, ModbusController? right)
        {
            return EqualityComparer<ModbusController?>.Default.Equals(left, right);
        }

        public static bool operator !=(ModbusController? left, ModbusController? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}