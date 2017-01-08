using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Business.Interfaces;
using Demo.Data;
using Demo.Entity;

namespace Demo.Business
{
    public class DemoBusinessService : IDemoBusinessService
    {
        public IEnumerable<Employee> RetrieveEmployees()
        {
            var dataService = new DemoDataService();
            return dataService.RetrieveEmployees().ToList();
        }
    }
}
