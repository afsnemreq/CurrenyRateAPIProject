using Currency;
using CurrenyRateAPIProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CurrenyRateAPIProject.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly ICurrencyService service;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
			service = new CurrencyService();
		}

		public async Task<IActionResult> Index()
		{
			var ratelist = await service.GetToday();

			return View(ratelist);
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
