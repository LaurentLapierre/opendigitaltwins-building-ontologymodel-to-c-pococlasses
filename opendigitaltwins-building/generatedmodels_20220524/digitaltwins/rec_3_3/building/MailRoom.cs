using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.building
{

    public class MailRoom : BackOffice, IEquatable<MailRoom>
    {
        public MailRoom()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:building:MailRoom;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as MailRoom);
        }

        public bool Equals(MailRoom? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(MailRoom? left, MailRoom? right)
        {
            return EqualityComparer<MailRoom?>.Default.Equals(left, right);
        }

        public static bool operator !=(MailRoom? left, MailRoom? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}