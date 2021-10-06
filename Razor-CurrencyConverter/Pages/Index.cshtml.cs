using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Razor_CurrencyConverter.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string FullName { get; set; }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            FullName = "Jason Huggins";
        }

        public void OnPost()
        {
            if (String.IsNullOrWhiteSpace(FullName))
            {
                ViewData["Message"] = "You haven't entered a name!";
                FullName = "Anonymous";
            }
            else
            {
                ViewData["Message"] = "This name is registered.";
                // Register user
            }
        }
    }
}
