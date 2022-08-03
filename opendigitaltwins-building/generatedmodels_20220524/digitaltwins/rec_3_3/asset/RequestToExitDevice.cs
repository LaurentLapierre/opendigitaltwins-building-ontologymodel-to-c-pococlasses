using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class RequestToExitDevice : AccessControlEquipment, IEquatable<RequestToExitDevice>
    {
        public RequestToExitDevice()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:RequestToExitDevice;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as RequestToExitDevice);
        }

        public bool Equals(RequestToExitDevice? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(RequestToExitDevice? left, RequestToExitDevice? right)
        {
            return EqualityComparer<RequestToExitDevice?>.Default.Equals(left, right);
        }

        public static bool operator !=(RequestToExitDevice? left, RequestToExitDevice? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}