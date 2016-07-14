using System;
using System.Xml.Serialization;

namespace InvoiceXpressDotNet
{
	[XmlRoot("invoices"), XmlType(AnonymousType=true)]
	public partial class InvoicesDto : Dto
	{		
		[XmlAttribute]
		public string type = "array";
		
		[XmlElement("invoice")]
		public InvoiceDto[] Items { get; set; }
		
		[XmlIgnore]
		public int? CurrentPage { get; set; }
		
		[XmlElement("current_page")]
	    public string _CurrentPageDto
	    {	    
			get { return CurrentPage.ToXml<int?>(); }
            set { CurrentPage = value.FromXml<int?>(); }
	    }
		
		[XmlIgnore]
		public int? TotalPages { get; set; }
		
		[XmlElement("total_pages")]
	    public string _TotalPagesDto
	    {	    
			get { return TotalPages.ToXml<int?>(); }
            set { TotalPages = value.FromXml<int?>(); }
	    }
		
		[XmlIgnore]
		public int? TotalEntries { get; set; }
		
		[XmlElement("total_entries")]
	    public string _TotalEntriesDto
	    {	    
			get { return TotalEntries.ToXml<int?>(); }
            set { TotalEntries = value.FromXml<int?>(); }
	    }
		
		[XmlIgnore]
		public int? PerPage { get; set; }
		
		[XmlElement("per_page")]
	    public string _PerPageDto
	    {	    
			get { return PerPage.ToXml<int?>(); }
            set { PerPage = value.FromXml<int?>(); }
	    }
		
		/*
		public override void SetFromXml(string xml)
		{
			var me = this;
			me = xml.DeserializeXml<InvoicesDto>();
        }
		*/
	}
}
