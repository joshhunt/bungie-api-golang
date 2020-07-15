using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	/// This component provides a quick lookup of every item the requested character has and how much of that item they have.
	/// Requesting this component will allow you to circumvent manually putting together the list of which currencies you have for the purpose of testing currency requirements on an item being purchased, or operations that have costs.
	/// You *could* figure this out yourself by doing a GetCharacter or GetProfile request and forming your own lookup table, but that is inconvenient enough that this feels like a worthwhile (and optional) redundency. Don&#39;t bother requesting it if you have already created your own lookup from prior GetCharacter&#x2F;GetProfile calls.
	[DataContract]
	public class DestinyCurrenciesComponent{

		/// <summary>
		/// A dictionary - keyed by the item's hash identifier (DestinyInventoryItemDefinition), and whose value is the amount of that item you have across all available inventory buckets for purchasing.
		/// </summary>
		/// <summary>
		/// This allows you to see whether the requesting character can afford any given purchase/action without having to re-create this list itself.
		/// </summary>
		[DataMember(Name="itemQuantities", EmitDefaultValue=false)]
		public Map<String, long> ItemQuantities { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyCurrenciesComponent);
        }

		public bool Equals(DestinyCurrenciesComponent input)
		{
			if (input == null) return false;

			return
				(
                    ItemQuantities == input.ItemQuantities ||
                    (ItemQuantities != null && ItemQuantities.Equals(input.ItemQuantities))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.ItemQuantities.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

