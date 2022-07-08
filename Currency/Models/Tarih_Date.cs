namespace Currency.Models
{
	// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
	/// <remarks/>
	[System.Serializable()]
	[System.ComponentModel.DesignerCategory("code")]
	[System.Xml.Serialization.XmlType(AnonymousType = true)]
	[System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
	public partial class Tarih_Date
	{

		private Tarih_DateCurrency[] currencyField;

		private string tarihField;

		private string dateField;

		private string bulten_NoField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElement("Currency")]
		public Tarih_DateCurrency[] Currency
		{
			get
			{
				return currencyField;
			}
			set
			{
				currencyField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttribute()]
		public string Tarih
		{
			get
			{
				return tarihField;
			}
			set
			{
				tarihField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttribute()]
		public string Date
		{
			get
			{
				return dateField;
			}
			set
			{
				dateField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttribute()]
		public string Bulten_No
		{
			get
			{
				return bulten_NoField;
			}
			set
			{
				bulten_NoField = value;
			}
		}
	}


}
