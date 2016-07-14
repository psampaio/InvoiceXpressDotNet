using System;
using System.Xml.Serialization;

namespace InvoiceXpressDotNet
{
	[XmlRoot("receipt"), XmlType(AnonymousType=true)]
	public partial class PartialPaymentReceiptDto : Dto
	{		
		
		[XmlIgnore]
		public int? Id { get; set; }
		
		[XmlElement("id")]
	    public string _IdDto
	    {	    
			get { return Id.ToXml<int?>(); }
            set { Id = value.FromXml<int?>(); }
	    }
		
		[XmlElement("status")]
		public DocumentState Status { get; set; }
		
		[XmlIgnore]
		public bool? Archived { get; set; }
		
		[XmlElement("archived")]
	    public string _ArchivedDto
	    {	    
			get { return Archived.ToXml<bool?>(); }
            set { Archived = value.FromXml<bool?>(); }
	    }
		
		[XmlElement("type")]
		public string Type { get; set; }
		
		[XmlElement("sequence_number")]
		public string SequenceNumber { get; set; }
		
		[XmlIgnore]
		public DateTime? Date { get; set; }
		
		[XmlElement("date")]
	    public string _DateDto
	    {	    
			get { return Date.ToXml<DateTime?>(); }
            set { Date = value.FromXml<DateTime?>(); }
	    }
		
		[XmlIgnore]
		public DateTime? DueDate { get; set; }
		
		[XmlElement("due_date")]
	    public string _DueDateDto
	    {	    
			get { return DueDate.ToXml<DateTime?>(); }
            set { DueDate = value.FromXml<DateTime?>(); }
	    }
		
		[XmlElement("observations")]
		public string Observations { get; set; }
		
		[XmlIgnore]
		public float? Retention { get; set; }
		
		[XmlElement("retention")]
	    public string _RetentionDto
	    {	    
			get { return Retention.ToXml<float?>(); }
            set { Retention = value.FromXml<float?>(); }
	    }
		
		[XmlElement("permalink")]
		public string Permalink { get; set; }
		
		[XmlIgnore]
		public float? Sum { get; set; }
		
		[XmlElement("sum")]
	    public string _SumDto
	    {	    
			get { return Sum.ToXml<float?>(); }
            set { Sum = value.FromXml<float?>(); }
	    }
		
		[XmlIgnore]
		public float? Discount { get; set; }
		
		[XmlElement("discount")]
	    public string _DiscountDto
	    {	    
			get { return Discount.ToXml<float?>(); }
            set { Discount = value.FromXml<float?>(); }
	    }
		
		[XmlIgnore]
		public float? BeforeTaxes { get; set; }
		
		[XmlElement("before_taxes")]
	    public string _BeforeTaxesDto
	    {	    
			get { return BeforeTaxes.ToXml<float?>(); }
            set { BeforeTaxes = value.FromXml<float?>(); }
	    }
		
		[XmlIgnore]
		public float? Taxes { get; set; }
		
		[XmlElement("taxes")]
	    public string _TaxesDto
	    {	    
			get { return Taxes.ToXml<float?>(); }
            set { Taxes = value.FromXml<float?>(); }
	    }
		
		[XmlIgnore]
		public float? Total { get; set; }
		
		[XmlElement("total")]
	    public string _TotalDto
	    {	    
			get { return Total.ToXml<float?>(); }
            set { Total = value.FromXml<float?>(); }
	    }
		
		[XmlElement("currency")]
		public string Currency { get; set; }
		
		[XmlElement("client")]
		public ClientDto Client { get; set; }
		
		[XmlElement("multicurrency")]
		public MulticurrencyDto Multicurrency { get; set; }
		
		[XmlElement("events")]
		public EventsDto Events { get; set; }
		
		/*
		public override void SetFromXml(string xml)
		{
			var me = this;
			me = xml.DeserializeXml<PartialPaymentReceiptDto>();
        }
		*/
	}
}
