using EmployeesManagement.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeesManagement.Web.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        [HttpGet]
        public IActionResult Error(string requestId, string errorInfo)
        {
            return View(new ErrorViewModel() { RequestId = requestId, ErrorInfo = errorInfo });
        }
    }
}
