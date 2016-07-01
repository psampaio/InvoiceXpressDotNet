using System;
using System.Xml.Serialization;
using System.ComponentModel;
namespace InvoiceXpressDotNet
{
	[XmlRoot("accounts"), XmlType(AnonymousType=true)]
	public partial class UserAccountsDto
	{
		[XmlAttribute]
		public string type = "array";
		
		[XmlElement("account")]
		public UserAccountDto[] AccountsArray { get; set; }
	}
}