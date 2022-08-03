using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.asset.relationship.faucet;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class Faucet : PlumbingFixture, IEquatable<Faucet>
    {
        public Faucet()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:Faucet;1";
        [JsonPropertyName("type")]
        public FaucetType? Type { get; set; }
        [JsonPropertyName("maxFlowRate")]
        public double? MaxFlowRate { get; set; }
        [JsonPropertyName("numberOfHandles")]
        public int? NumberOfHandles { get; set; }
        [JsonIgnore]
        public FaucetMountedOnRelationshipCollection MountedOn { get; set; } = new FaucetMountedOnRelationshipCollection();
        public override bool Equals(object? obj)
        {
            return Equals(obj as Faucet);
        }

        public bool Equals(Faucet? other)
        {
            return other is not null && base.Equals(other) && Type == other.Type && MaxFlowRate == other.MaxFlowRate && NumberOfHandles == other.NumberOfHandles;
        }

        public static bool operator ==(Faucet? left, Faucet? right)
        {
            return EqualityComparer<Faucet?>.Default.Equals(left, right);
        }

        public static bool operator !=(Faucet? left, Faucet? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Type?.GetHashCode(), MaxFlowRate?.GetHashCode(), NumberOfHandles?.GetHashCode());
        }
    }
}