using System;
using System.Xml.Serialization;

namespace InvoiceXpressDotNet
{
	[XmlRoot("events"), XmlType(AnonymousType=true)]
	public partial class EventsDto : Dto
	{		
		[XmlAttribute]
		public string type = "array";
		
		[XmlElement("event")]
		public EventDto[] Items { get; set; }
		
		/*
		public override void SetFromXml(string xml)
		{
			var me = this;
			me = xml.DeserializeXml<EventsDto>();
        }
		*/
	}
}
