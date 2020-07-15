using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	/// These definitions represent vendors&#39; locations and relevant display information at different times in the game.
	[DataContract]
	public class DestinyVendorLocationDefinition{

		/// <summary>
		/// The hash identifier for a Destination at which this vendor may be located. Each destination where a Vendor may exist will only ever have a single entry.
		/// </summary>
		[DataMember(Name="destinationHash", EmitDefaultValue=false)]
		public uint DestinationHash { get; set; }

		/// <summary>
		/// The relative path to the background image representing this Vendor at this location, for use in a banner.
		/// </summary>
		[DataMember(Name="backgroundImagePath", EmitDefaultValue=false)]
		public string BackgroundImagePath { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyVendorLocationDefinition);
        }

		public bool Equals(DestinyVendorLocationDefinition input)
		{
			if (input == null) return false;

			return
				(
                    DestinationHash == input.DestinationHash ||
                    (DestinationHash != null && DestinationHash.Equals(input.DestinationHash))
                ) &&
				(
                    BackgroundImagePath == input.BackgroundImagePath ||
                    (BackgroundImagePath != null && BackgroundImagePath.Equals(input.BackgroundImagePath))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.DestinationHash.GetHashCode();
				hashCode = hashCode * 59 + this.BackgroundImagePath.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

