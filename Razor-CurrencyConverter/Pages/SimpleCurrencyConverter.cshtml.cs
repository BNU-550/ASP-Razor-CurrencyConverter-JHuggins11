using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Razor_CurrencyConverter.Pages
{
    public class SimpleCurrencyConverterModel : PageModel
    {
        public const double GBP_JPY_RATE = 152.74;

        [BindProperty]
        public double InputAmount { get; set; }
        [BindProperty]
        public double OutputAmount { get; set; }

        private readonly ILogger<SimpleCurrencyConverterModel> _logger;

        public SimpleCurrencyConverterModel
            (ILogger<SimpleCurrencyConverterModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            if (Double.IsNaN(InputAmount))
            {
                ViewData["Message"] = "Invalid type. " +
                    "The input must be a number.";
            }
            else if (Double.IsNegative(InputAmount))
            {
                ViewData["Message"] = "Invalid input. " +
                    "The input cannot be negative.";
            }
            else if (InputAmount > 0)
            {
                OutputAmount = InputAmount * GBP_JPY_RATE;
                ViewData["Message"] = "Amount converted at ratio £1 : ¥152.74.";
            }
        }
    }
}
