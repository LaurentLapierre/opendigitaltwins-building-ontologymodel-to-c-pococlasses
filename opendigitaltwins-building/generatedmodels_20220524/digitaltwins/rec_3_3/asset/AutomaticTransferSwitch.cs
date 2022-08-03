using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class AutomaticTransferSwitch : TransferSwitch, IEquatable<AutomaticTransferSwitch>
    {
        public AutomaticTransferSwitch()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:AutomaticTransferSwitch;1";
        [JsonPropertyName("transitionType")]
        public AutomaticTransferSwitchTransitionType? TransitionType { get; set; }
        [JsonPropertyName("switchingMechanism")]
        public AutomaticTransferSwitchSwitchingMechanism? SwitchingMechanism { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as AutomaticTransferSwitch);
        }

        public bool Equals(AutomaticTransferSwitch? other)
        {
            return other is not null && base.Equals(other) && TransitionType == other.TransitionType && SwitchingMechanism == other.SwitchingMechanism;
        }

        public static bool operator ==(AutomaticTransferSwitch? left, AutomaticTransferSwitch? right)
        {
            return EqualityComparer<AutomaticTransferSwitch?>.Default.Equals(left, right);
        }

        public static bool operator !=(AutomaticTransferSwitch? left, AutomaticTransferSwitch? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), TransitionType?.GetHashCode(), SwitchingMechanism?.GetHashCode());
        }
    }
}