using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.core.relationship.asset;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.core
{

    public class Asset : BasicDigitalTwin, IEquatable<Asset>, IEquatable<BasicDigitalTwin>
    {
        public Asset()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:core:Asset;1";
        [JsonPropertyName("serialNumber")]
        public string? SerialNumber { get; set; }
        [JsonPropertyName("physicalTagNumber")]
        public string? PhysicalTagNumber { get; set; }
        [JsonPropertyName("modelNumber")]
        public string? ModelNumber { get; set; }
        [JsonPropertyName("MACAddress")]
        public string? MACAddress { get; set; }
        [JsonPropertyName("IPAddress")]
        public string? IPAddress { get; set; }
        [JsonPropertyName("weight")]
        public double? Weight { get; set; }
        [JsonPropertyName("turnoverDate")]
        public DateTime? TurnoverDate { get; set; }
        [JsonPropertyName("maintenanceInterval")]
        public TimeSpan? MaintenanceInterval { get; set; }
        [JsonPropertyName("installationDate")]
        public DateTime? InstallationDate { get; set; }
        [JsonPropertyName("initialCost")]
        public string? InitialCost { get; set; }
        [JsonPropertyName("expectedReplacementCost")]
        public string? ExpectedReplacementCost { get; set; }
        [JsonPropertyName("expectedLife")]
        public TimeSpan? ExpectedLife { get; set; }
        [JsonPropertyName("expectedEndOfLife")]
        public DateTime? ExpectedEndOfLife { get; set; }
        [JsonPropertyName("commissionDate")]
        public DateTime? CommissionDate { get; set; }
        [JsonIgnore]
        public AssetServesRelationshipCollection Serves { get; set; } = new AssetServesRelationshipCollection();
        [JsonIgnore]
        public AssetServedByRelationshipCollection ServedBy { get; set; } = new AssetServedByRelationshipCollection();
        [JsonIgnore]
        public AssetIsPartOfRelationshipCollection IsPartOf { get; set; } = new AssetIsPartOfRelationshipCollection();
        [JsonIgnore]
        public AssetIncludedInRelationshipCollection IncludedIn { get; set; } = new AssetIncludedInRelationshipCollection();
        [JsonIgnore]
        public AssetHasPartRelationshipCollection HasPart { get; set; } = new AssetHasPartRelationshipCollection();
        [JsonIgnore]
        public AssetHasCapabilityRelationshipCollection HasCapability { get; set; } = new AssetHasCapabilityRelationshipCollection();
        [JsonIgnore]
        public AssetLocatedInRelationshipCollection LocatedIn { get; set; } = new AssetLocatedInRelationshipCollection();
        [JsonIgnore]
        public AssetServicedByRelationshipCollection ServicedBy { get; set; } = new AssetServicedByRelationshipCollection();
        [JsonIgnore]
        public AssetManufacturedByRelationshipCollection ManufacturedBy { get; set; } = new AssetManufacturedByRelationshipCollection();
        [JsonIgnore]
        public AssetInstalledByRelationshipCollection InstalledBy { get; set; } = new AssetInstalledByRelationshipCollection();
        [JsonIgnore]
        public AssetCommissionedByRelationshipCollection CommissionedBy { get; set; } = new AssetCommissionedByRelationshipCollection();
        [JsonIgnore]
        public AssetHostsRelationshipCollection Hosts { get; set; } = new AssetHostsRelationshipCollection();
        [JsonPropertyName("customTags")]
        public IDictionary<string, string>? CustomTags { get; set; }
        [JsonPropertyName("externalIds")]
        public IDictionary<string, string>? ExternalIds { get; set; }
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as Asset);
        }

        public bool Equals(Asset? other)
        {
            return other is not null && Id == other.Id && Metadata.ModelId == other.Metadata.ModelId && SerialNumber == other.SerialNumber && PhysicalTagNumber == other.PhysicalTagNumber && ModelNumber == other.ModelNumber && MACAddress == other.MACAddress && IPAddress == other.IPAddress && Weight == other.Weight && TurnoverDate == other.TurnoverDate && MaintenanceInterval == other.MaintenanceInterval && InstallationDate == other.InstallationDate && InitialCost == other.InitialCost && ExpectedReplacementCost == other.ExpectedReplacementCost && ExpectedLife == other.ExpectedLife && ExpectedEndOfLife == other.ExpectedEndOfLife && CommissionDate == other.CommissionDate && CustomTags == other.CustomTags && ExternalIds == other.ExternalIds && Name == other.Name;
        }

        public static bool operator ==(Asset? left, Asset? right)
        {
            return EqualityComparer<Asset?>.Default.Equals(left, right);
        }

        public static bool operator !=(Asset? left, Asset? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(Id?.GetHashCode(), Metadata?.ModelId?.GetHashCode(), SerialNumber?.GetHashCode(), PhysicalTagNumber?.GetHashCode(), ModelNumber?.GetHashCode(), MACAddress?.GetHashCode(), IPAddress?.GetHashCode(), Weight?.GetHashCode(), TurnoverDate?.GetHashCode(), MaintenanceInterval?.GetHashCode(), InstallationDate?.GetHashCode(), InitialCost?.GetHashCode(), ExpectedReplacementCost?.GetHashCode(), ExpectedLife?.GetHashCode(), ExpectedEndOfLife?.GetHashCode(), CommissionDate?.GetHashCode(), CustomTags?.GetHashCode(), ExternalIds?.GetHashCode(), Name?.GetHashCode());
        }

        public bool Equals(BasicDigitalTwin? other)
        {
            return Equals(other as Asset) || new TwinEqualityComparer().Equals(this, other);
        }
    }
}