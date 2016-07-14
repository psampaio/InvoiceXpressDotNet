using System;
using System.Xml.Serialization;

namespace InvoiceXpressDotNet
{
	[XmlRoot("AccountName"), XmlType(AnonymousType=true)]
	public partial class UserAccountDto : Dto
	{		
		
		[XmlIgnore]
		public int? Id { get; set; }
		
		[XmlElement("id")]
	    public string _IdDto
	    {	    
			get { return Id.ToXml<int?>(); }
            set { Id = value.FromXml<int?>(); }
	    }
		
		[XmlElement("name")]
		public string Name { get; set; }
		
		[XmlElement("url")]
		public string Url { get; set; }
		
		[XmlElement("api_key")]
		public string ApiKey { get; set; }
		
		[XmlElement("state")]
		public string State { get; set; }
		
		[XmlElement("blocked")]
		public string Blocked { get; set; }
		
		[XmlElement("roles")]
		public RolesDto Roles { get; set; }
		
		/*
		public override void SetFromXml(string xml)
		{
			var me = this;
			me = xml.DeserializeXml<UserAccountDto>();
        }
		*/
	}
}
