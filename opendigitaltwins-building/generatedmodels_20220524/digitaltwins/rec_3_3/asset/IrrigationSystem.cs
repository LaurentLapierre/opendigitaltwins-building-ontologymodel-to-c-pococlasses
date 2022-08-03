using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class IrrigationSystem : PlumbingWaterSystem, IEquatable<IrrigationSystem>
    {
        public IrrigationSystem()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:IrrigationSystem;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as IrrigationSystem);
        }

        public bool Equals(IrrigationSystem? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(IrrigationSystem? left, IrrigationSystem? right)
        {
            return EqualityComparer<IrrigationSystem?>.Default.Equals(left, right);
        }

        public static bool operator !=(IrrigationSystem? left, IrrigationSystem? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}