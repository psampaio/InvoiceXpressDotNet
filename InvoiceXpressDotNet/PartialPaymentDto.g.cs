using System;
using System.Xml.Serialization;

namespace InvoiceXpressDotNet
{
	[XmlRoot("partial_payment"), XmlType(AnonymousType=true)]
	public partial class PartialPaymentDto : Dto
	{		
		
		[XmlElement("payment_mechanism")]
		public PaymentMechanism PaymentMechanism { get; set; }
		
		[XmlElement("note")]
		public string Note { get; set; }
		
		[XmlElement("serie")]
		public string Serie { get; set; }
		
		[XmlIgnore]
		public float? Amount { get; set; }
		
		[XmlElement("amount")]
	    public string _AmountDto
	    {	    
			get { return Amount.ToXml<float?>(); }
            set { Amount = value.FromXml<float?>(); }
	    }
		
		[XmlIgnore]
		public DateTime? PaymentDate { get; set; }
		
		[XmlElement("payment_date")]
	    public string _PaymentDateDto
	    {	    
			get { return PaymentDate.ToXml<DateTime?>(); }
            set { PaymentDate = value.FromXml<DateTime?>(); }
	    }
		
		/*
		public override void SetFromXml(string xml)
		{
			var me = this;
			me = xml.DeserializeXml<PartialPaymentDto>();
        }
		*/
	}
}
