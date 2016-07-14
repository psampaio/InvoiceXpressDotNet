using System;
using System.Xml.Serialization;

namespace InvoiceXpressDotNet
{
	[XmlRoot("invoice"), XmlType(AnonymousType=true)]
	public partial class InvoiceChangeStateDto : Dto
	{		
		
		[XmlElement("id")]
		public int Id { get; set; }
		
		[XmlElement("type")]
		public string Type { get; set; }
		
		[XmlElement("sequence_number")]
		public string SequenceNumber { get; set; }
		
		[XmlElement("message")]
		public string Message { get; set; }
		
		[XmlElement("state")]
		public DocumentState State { get; set; }
		
		/*
		public override void SetFromXml(string xml)
		{
			var me = this;
			me = xml.DeserializeXml<InvoiceChangeStateDto>();
        }
		*/
	}
}
