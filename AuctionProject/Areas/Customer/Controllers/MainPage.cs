using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuctionProject.Areas.Customer.Controllers
{
    public class MainPage : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
