using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	[DataContract]
	public class AwaPermissionRequested{

		/// <summary>
		/// Type of advanced write action.
		/// </summary>
		[DataMember(Name="type", EmitDefaultValue=false)]
		public AwaType Type { get; set; }

		/// <summary>
		/// Item instance ID the action shall be applied to. This is optional for all but a new AwaType values. Rule of thumb is to provide the item instance ID if one is available.
		/// </summary>
		[DataMember(Name="affectedItemId", EmitDefaultValue=false)]
		public long AffectedItemId { get; set; }

		/// <summary>
		/// Destiny membership type of the account to modify.
		/// </summary>
		[DataMember(Name="membershipType", EmitDefaultValue=false)]
		public BungieMembershipType MembershipType { get; set; }

		/// <summary>
		/// Destiny character ID, if applicable, that will be affected by the action.
		/// </summary>
		[DataMember(Name="characterId", EmitDefaultValue=false)]
		public long CharacterId { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as AwaPermissionRequested);
        }

		public bool Equals(AwaPermissionRequested input)
		{
			if (input == null) return false;

			return
				(
                    Type == input.Type ||
                    (Type != null && Type.Equals(input.Type))
                ) &&
				(
                    AffectedItemId == input.AffectedItemId ||
                    (AffectedItemId != null && AffectedItemId.Equals(input.AffectedItemId))
                ) &&
				(
                    MembershipType == input.MembershipType ||
                    (MembershipType != null && MembershipType.Equals(input.MembershipType))
                ) &&
				(
                    CharacterId == input.CharacterId ||
                    (CharacterId != null && CharacterId.Equals(input.CharacterId))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.Type.GetHashCode();
				hashCode = hashCode * 59 + this.AffectedItemId.GetHashCode();
				hashCode = hashCode * 59 + this.MembershipType.GetHashCode();
				hashCode = hashCode * 59 + this.CharacterId.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

