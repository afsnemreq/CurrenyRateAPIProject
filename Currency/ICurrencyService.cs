using Currency.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Currency
{
	public interface ICurrencyService
	{
		public Task<CurrencyModel[]> GetToday();
	}

}
