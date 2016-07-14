using System;
using System.Xml.Serialization;

namespace InvoiceXpressDotNet
{
	[XmlRoot("AccountName_stats"), XmlType(AnonymousType=true)]
	public partial class AccountStatsDto : Dto
	{		
		
		[XmlElement("plan")]
		public string Plan { get; set; }
		
		[XmlElement("expires_at")]
		public string ExpiresAt { get; set; }
		
		[XmlElement("documents")]
		public DocumentsStatsDto Documents { get; set; }
		
		[XmlElement("users")]
		public UsersStatsDto Users { get; set; }
		
		/*
		public override void SetFromXml(string xml)
		{
			var me = this;
			me = xml.DeserializeXml<AccountStatsDto>();
        }
		*/
	}
}
