using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	[DataContract]
	public class DictionaryComponentResponseOfint64AndDestinyItemPerksComponent{

		[DataMember(Name="data", EmitDefaultValue=false)]
		public Map<String, DestinyItemPerksComponent> Data { get; set; }

		[DataMember(Name="privacy", EmitDefaultValue=false)]
		public ComponentPrivacySetting Privacy { get; set; }

		/// <summary>
		/// If true, this component is disabled.
		/// </summary>
		[DataMember(Name="disabled", EmitDefaultValue=false)]
		public bool Disabled { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DictionaryComponentResponseOfint64AndDestinyItemPerksComponent);
        }

		public bool Equals(DictionaryComponentResponseOfint64AndDestinyItemPerksComponent input)
		{
			if (input == null) return false;

			return
				(
                    Data == input.Data ||
                    (Data != null && Data.Equals(input.Data))
                ) &&
				(
                    Privacy == input.Privacy ||
                    (Privacy != null && Privacy.Equals(input.Privacy))
                ) &&
				(
                    Disabled == input.Disabled ||
                    (Disabled != null && Disabled.Equals(input.Disabled))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.Data.GetHashCode();
				hashCode = hashCode * 59 + this.Privacy.GetHashCode();
				hashCode = hashCode * 59 + this.Disabled.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

