using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	/// Represents a variant on an activity for a Milestone: a specific difficulty tier, or a specific activity variant for example.
	/// These will often have more specific details, such as an associated Guided Game, progression steps, tier-specific rewards, and custom values.
	[DataContract]
	public class DestinyMilestoneActivityVariantDefinition{

		/// <summary>
		/// The hash to use for looking up the variant Activity's definition (DestinyActivityDefinition), where you can find its distinguishing characteristics such as difficulty level and recommended light level. 
		/// </summary>
		/// <summary>
		/// Frequently, that will be the only distinguishing characteristics in practice, which is somewhat of a bummer.
		/// </summary>
		[DataMember(Name="activityHash", EmitDefaultValue=false)]
		public uint ActivityHash { get; set; }

		/// <summary>
		/// If you care to do so, render the variants in the order prescribed by this value.
		/// </summary>
		/// <summary>
		/// When you combine live Milestone data with the definition, the order becomes more useful because you'll be cross-referencing between the definition and live data.
		/// </summary>
		[DataMember(Name="order", EmitDefaultValue=false)]
		public long Order { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyMilestoneActivityVariantDefinition);
        }

		public bool Equals(DestinyMilestoneActivityVariantDefinition input)
		{
			if (input == null) return false;

			return
				(
                    ActivityHash == input.ActivityHash ||
                    (ActivityHash != null && ActivityHash.Equals(input.ActivityHash))
                ) &&
				(
                    Order == input.Order ||
                    (Order != null && Order.Equals(input.Order))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.ActivityHash.GetHashCode();
				hashCode = hashCode * 59 + this.Order.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

