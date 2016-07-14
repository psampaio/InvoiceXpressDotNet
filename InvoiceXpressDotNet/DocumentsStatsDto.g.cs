using System;
using System.Xml.Serialization;

namespace InvoiceXpressDotNet
{
	[XmlRoot("documents"), XmlType(AnonymousType=true)]
	public partial class DocumentsStatsDto : Dto
	{		
		
		[XmlIgnore]
		public int? UsedDocuments { get; set; }
		
		[XmlElement("used_documents")]
	    public string _UsedDocumentsDto
	    {	    
			get { return UsedDocuments.ToXml<int?>(); }
            set { UsedDocuments = value.FromXml<int?>(); }
	    }
		
		[XmlIgnore]
		public int? AvailableDocuments { get; set; }
		
		[XmlElement("available_documents")]
	    public string _AvailableDocumentsDto
	    {	    
			get { return AvailableDocuments.ToXml<int?>(); }
            set { AvailableDocuments = value.FromXml<int?>(); }
	    }
		
		[XmlIgnore]
		public int? UsedApiDocuments { get; set; }
		
		[XmlElement("used_api_documents")]
	    public string _UsedApiDocumentsDto
	    {	    
			get { return UsedApiDocuments.ToXml<int?>(); }
            set { UsedApiDocuments = value.FromXml<int?>(); }
	    }
		
		[XmlIgnore]
		public int? AvailableApiDocuments { get; set; }
		
		[XmlElement("available_api_documents")]
	    public string _AvailableApiDocumentsDto
	    {	    
			get { return AvailableApiDocuments.ToXml<int?>(); }
            set { AvailableApiDocuments = value.FromXml<int?>(); }
	    }
		
		[XmlIgnore]
		public int? UsedWebDocuments { get; set; }
		
		[XmlElement("used_web_documents")]
	    public string _UsedWebDocumentsDto
	    {	    
			get { return UsedWebDocuments.ToXml<int?>(); }
            set { UsedWebDocuments = value.FromXml<int?>(); }
	    }
		
		[XmlIgnore]
		public int? AvailableWebDocuments { get; set; }
		
		[XmlElement("available_web_documents")]
	    public string _AvailableWebDocumentsDto
	    {	    
			get { return AvailableWebDocuments.ToXml<int?>(); }
            set { AvailableWebDocuments = value.FromXml<int?>(); }
	    }
		
		/*
		public override void SetFromXml(string xml)
		{
			var me = this;
			me = xml.DeserializeXml<DocumentsStatsDto>();
        }
		*/
	}
}
