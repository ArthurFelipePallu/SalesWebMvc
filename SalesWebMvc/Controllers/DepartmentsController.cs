using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;

namespace SalesWebMvc.Controllers;

public class DepartmentsController : Controller
{
    // GET
    public IActionResult Index()
    {
        var departments = new List<Department>();
        departments.Add(new Department{Id = 1, Name = "Eletronics"});
        departments.Add(new Department{Id = 2, Name = "Fashion"});
        departments.Add(new Department{Id = 3, Name = "Toys"});
        departments.Add(new Department{Id = 4, Name = "Books"});
        
        return View(departments);
    }
}