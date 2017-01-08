using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Demo.Entity;

namespace DemoMvc.Models
{
    public class EmployeeViewModel
    {
        public Employee Employee { get; set; }
        public List<string> Name { get; set; } 
    }
}