using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	/// Defines the conditions under which an intrinsic perk is applied while participating in an Objective.
	/// These perks will generally not be benefit-granting perks, but rather a perk that modifies gameplay in some interesting way.
	[DataContract]
	public class DestinyObjectivePerkEntryDefinition{

		/// <summary>
		/// The hash identifier of the DestinySandboxPerkDefinition that will be applied to the character.
		/// </summary>
		[DataMember(Name="perkHash", EmitDefaultValue=false)]
		public uint PerkHash { get; set; }

		/// <summary>
		/// An enumeration indicating whether it will be applied as long as the Objective is active, when it's completed, or until it's completed.
		/// </summary>
		[DataMember(Name="style", EmitDefaultValue=false)]
		public DestinyObjectiveGrantStyle Style { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyObjectivePerkEntryDefinition);
        }

		public bool Equals(DestinyObjectivePerkEntryDefinition input)
		{
			if (input == null) return false;

			return
				(
                    PerkHash == input.PerkHash ||
                    (PerkHash != null && PerkHash.Equals(input.PerkHash))
                ) &&
				(
                    Style == input.Style ||
                    (Style != null && Style.Equals(input.Style))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.PerkHash.GetHashCode();
				hashCode = hashCode * 59 + this.Style.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

