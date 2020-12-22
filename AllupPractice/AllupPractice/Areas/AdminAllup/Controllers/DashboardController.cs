using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllupPractice.Areas.AdminAllup.Controllers
{
    [Area("AdminAllup")] 
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
