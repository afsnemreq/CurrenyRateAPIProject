using Currency.Models;
using Currency.Serializer;
using System;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Currency
{
	public class CurrencyService : ICurrencyService
	{
		private string urlPatter = "http://www.tcmb.gov.tr/kurlar/{0}.xml";
		private readonly WebClient client;
		private readonly IXmlSerializer serializer;

		public CurrencyService()
		{
			client = new WebClient
			{
				Encoding = Encoding.UTF8
			};
			serializer = new XmlSerializer();
		}

		public Task<CurrencyModel[]> GetToday()
		{
			var url = new Uri(string.Format(urlPatter, "today"));
			var data = client.DownloadString(url);
			var deserialize = serializer.Deserializer<Tarih_Date>(data);
			var result = deserialize.Currency.Select(CurrencyModel.Map).ToArray();
			return Task.FromResult(result);
		}
	}

}
