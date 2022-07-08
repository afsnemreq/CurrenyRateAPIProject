namespace Currency.Models
{
	/// <remarks/>
	[System.Serializable()]
	[System.ComponentModel.DesignerCategory("code")]
	[System.Xml.Serialization.XmlType(AnonymousType = true)]
	public partial class Tarih_DateCurrency
	{
		private byte unitField;

		private string isimField;

		private string currencyNameField;

		private decimal forexBuyingField;

		private string forexSellingField;

		private string banknoteBuyingField;

		private string banknoteSellingField;

		private string crossRateUSDField;

		private string crossRateOtherField;

		private byte crossOrderField;

		private string kodField;

		private string currencyCodeField;

		/// <remarks/>
		public byte Unit
		{
			get
			{
				return unitField;
			}
			set
			{
				unitField = value;
			}
		}
		public int MyProperty { get; set; }
		/// <remarks/>
		public string Isim
		{
			get
			{
				return isimField;
			}
			set
			{
				isimField = value;
			}
		}

		/// <remarks/>
		public string CurrencyName
		{
			get
			{
				return currencyNameField;
			}
			set
			{
				currencyNameField = value;
			}
		}

		/// <remarks/>
		public decimal ForexBuying
		{
			get
			{
				return forexBuyingField;
			}
			set
			{
				forexBuyingField = value;
			}
		}

		/// <remarks/>
		public string ForexSelling
		{
			get
			{
				return forexSellingField;
			}
			set
			{
				forexSellingField = value;
			}
		}

		/// <remarks/>
		public string BanknoteBuying
		{
			get
			{
				return banknoteBuyingField;
			}
			set
			{
				banknoteBuyingField = value;
			}
		}

		/// <remarks/>
		public string BanknoteSelling
		{
			get
			{
				return banknoteSellingField;
			}
			set
			{
				banknoteSellingField = value;
			}
		}

		/// <remarks/>
		public string CrossRateUSD
		{
			get
			{
				return crossRateUSDField;
			}
			set
			{
				crossRateUSDField = value;
			}
		}

		/// <remarks/>
		public string CrossRateOther
		{
			get
			{
				return crossRateOtherField;
			}
			set
			{
				crossRateOtherField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttribute()]
		public byte CrossOrder
		{
			get
			{
				return crossOrderField;
			}
			set
			{
				crossOrderField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttribute()]
		public string Kod
		{
			get
			{
				return kodField;
			}
			set
			{
				kodField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttribute()]
		public string CurrencyCode
		{
			get
			{
				return currencyCodeField;
			}
			set
			{
				currencyCodeField = value;
			}
		}
	}


}
