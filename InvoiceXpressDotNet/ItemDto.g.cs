using System;
using System.Xml.Serialization;

namespace InvoiceXpressDotNet
{
	[XmlRoot("item"), XmlType(AnonymousType=true)]
	public partial class ItemDto : Dto
	{		
		
		[XmlElement("name")]
		public string Name { get; set; }
		
		[XmlElement("description")]
		public string Description { get; set; }
		
		[XmlIgnore]
		public float? UnitPrice { get; set; }
		
		[XmlElement("unit_price")]
	    public string _UnitPriceDto
	    {	    
			get { return UnitPrice.ToXml<float?>(); }
            set { UnitPrice = value.FromXml<float?>(); }
	    }
		
		[XmlElement("unit")]
		public string Unit { get; set; }
		
		[XmlIgnore]
		public float? Quantity { get; set; }
		
		[XmlElement("quantity")]
	    public string _QuantityDto
	    {	    
			get { return Quantity.ToXml<float?>(); }
            set { Quantity = value.FromXml<float?>(); }
	    }
		
		[XmlElement("tax")]
		public TaxDto Tax { get; set; }
		
		[XmlIgnore]
		public float? Discount { get; set; }
		
		[XmlElement("discount")]
	    public string _DiscountDto
	    {	    
			get { return Discount.ToXml<float?>(); }
            set { Discount = value.FromXml<float?>(); }
	    }
		
		[XmlIgnore]
		public float? Subtotal { get; set; }
		
		[XmlElement("subtotal")]
	    public string _SubtotalDto
	    {	    
			get { return Subtotal.ToXml<float?>(); }
            set { Subtotal = value.FromXml<float?>(); }
	    }
		
		[XmlIgnore]
		public float? TaxAmount { get; set; }
		
		[XmlElement("tax_amount")]
	    public string _TaxAmountDto
	    {	    
			get { return TaxAmount.ToXml<float?>(); }
            set { TaxAmount = value.FromXml<float?>(); }
	    }
		
		[XmlIgnore]
		public float? DiscountAmount { get; set; }
		
		[XmlElement("discount_amount")]
	    public string _DiscountAmountDto
	    {	    
			get { return DiscountAmount.ToXml<float?>(); }
            set { DiscountAmount = value.FromXml<float?>(); }
	    }
		
		[XmlIgnore]
		public float? Total { get; set; }
		
		[XmlElement("total")]
	    public string _TotalDto
	    {	    
			get { return Total.ToXml<float?>(); }
            set { Total = value.FromXml<float?>(); }
	    }
		
		/*
		public override void SetFromXml(string xml)
		{
			var me = this;
			me = xml.DeserializeXml<ItemDto>();
        }
		*/
	}
}
