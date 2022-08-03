using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class IrrigationPump : PlumbingPump, IEquatable<IrrigationPump>
    {
        public IrrigationPump()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:IrrigationPump;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as IrrigationPump);
        }

        public bool Equals(IrrigationPump? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(IrrigationPump? left, IrrigationPump? right)
        {
            return EqualityComparer<IrrigationPump?>.Default.Equals(left, right);
        }

        public static bool operator !=(IrrigationPump? left, IrrigationPump? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}