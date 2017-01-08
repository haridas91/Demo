using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web.Mvc;
using Demo.Business;
using Demo.Entity;
using DemoMvc.Models;

namespace DemoMvc.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        { 
            var demoBusiness = new DemoBusinessService();
            var data = demoBusiness.RetrieveEmployees();

            // var model = new List<string>();
            var name = new List<string>();
            
            
            foreach (var item in data)
            {
                name.Add(item.Name.ToString());
            }
            var model = new EmployeeViewModel()
            {
                Name = name
            };

            return View(model);
        }
    }
}