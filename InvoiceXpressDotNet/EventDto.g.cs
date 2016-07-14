using System;
using System.Xml.Serialization;

namespace InvoiceXpressDotNet
{
	[XmlRoot("event"), XmlType(AnonymousType=true)]
	public partial class EventDto : Dto
	{		
		
		[XmlElement("type")]
		public string Type { get; set; }
		
		[XmlIgnore]
		public DateTime? Date { get; set; }
		
		[XmlElement("date")]
	    public string _DateDto
	    {	    
			get { return Date.ToXml<DateTime?>(); }
            set { Date = value.FromXml<DateTime?>(); }
	    }
		
		[XmlElement("time")]
		public string Time { get; set; }
		
		[XmlElement("user")]
		public string User { get; set; }
		
		/*
		public override void SetFromXml(string xml)
		{
			var me = this;
			me = xml.DeserializeXml<EventDto>();
        }
		*/
	}
}
