using System;
using System.Xml.Serialization;

namespace InvoiceXpressDotNet
{
	[XmlRoot("users"), XmlType(AnonymousType=true)]
	public partial class UsersStatsDto : Dto
	{		
		
		[XmlIgnore]
		public int? UsedUsers { get; set; }
		
		[XmlElement("used_users")]
	    public string _UsedUsersDto
	    {	    
			get { return UsedUsers.ToXml<int?>(); }
            set { UsedUsers = value.FromXml<int?>(); }
	    }
		
		[XmlIgnore]
		public int? AvailableUsers { get; set; }
		
		[XmlElement("available_users")]
	    public string _AvailableUsersDto
	    {	    
			get { return AvailableUsers.ToXml<int?>(); }
            set { AvailableUsers = value.FromXml<int?>(); }
	    }
		
		/*
		public override void SetFromXml(string xml)
		{
			var me = this;
			me = xml.DeserializeXml<UsersStatsDto>();
        }
		*/
	}
}
