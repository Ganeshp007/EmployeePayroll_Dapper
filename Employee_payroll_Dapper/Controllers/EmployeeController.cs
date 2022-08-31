using Microsoft.AspNetCore.Mvc;

namespace Employee_payroll_Dapper.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
