using System;
using System.Xml.Serialization;

namespace InvoiceXpressDotNet
{
	[XmlRoot("change_AccountName_to"), XmlType(AnonymousType=true)]
	public partial class ChangeAccountToDto : Dto
	{		
		
		[XmlIgnore]
		public int? Id { get; set; }
		
		[XmlElement("id")]
	    public string _IdDto
	    {	    
			get { return Id.ToXml<int?>(); }
            set { Id = value.FromXml<int?>(); }
	    }
		
		/*
		public override void SetFromXml(string xml)
		{
			var me = this;
			me = xml.DeserializeXml<ChangeAccountToDto>();
        }
		*/
	}
}
