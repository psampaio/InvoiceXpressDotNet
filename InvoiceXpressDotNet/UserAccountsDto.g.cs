using System;
using System.Xml.Serialization;
using System.ComponentModel;
namespace InvoiceXpressDotNet
{
	[XmlRoot("accounts"), XmlType(AnonymousType=true)]
	public partial class UserAccountsDto : Dto
	{		
		[XmlAttribute]
		public string type = "array";
		
		[XmlElement("account")]
		public UserAccountDto[] Items { get; set; }
		
		/*
		public override void SetFromXml(string xml)
		{
			var me = this;
			me = xml.DeserializeXml<UserAccountsDto>();
        }
		*/
	}
}
