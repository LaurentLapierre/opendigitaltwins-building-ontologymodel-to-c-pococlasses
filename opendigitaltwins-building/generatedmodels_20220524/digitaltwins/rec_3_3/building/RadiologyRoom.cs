using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.building
{

    public class RadiologyRoom : HealthcareRoom, IEquatable<RadiologyRoom>
    {
        public RadiologyRoom()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:building:RadiologyRoom;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as RadiologyRoom);
        }

        public bool Equals(RadiologyRoom? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(RadiologyRoom? left, RadiologyRoom? right)
        {
            return EqualityComparer<RadiologyRoom?>.Default.Equals(left, right);
        }

        public static bool operator !=(RadiologyRoom? left, RadiologyRoom? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}