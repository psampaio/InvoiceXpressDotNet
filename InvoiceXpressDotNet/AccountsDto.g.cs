using System;
using System.Xml.Serialization;

namespace InvoiceXpressDotNet
{
	[XmlRoot("AccountNames"), XmlType(AnonymousType=true)]
	public partial class AccountsDto : Dto
	{		
		[XmlAttribute]
		public string type = "array";
		
		[XmlElement("AccountName")]
		public AccountDto[] Items { get; set; }
		
		/*
		public override void SetFromXml(string xml)
		{
			var me = this;
			me = xml.DeserializeXml<AccountsDto>();
        }
		*/
	}
}
