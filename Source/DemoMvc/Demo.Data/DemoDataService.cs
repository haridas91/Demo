using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Demo.Data.Interfaces;
using Demo.Entity;

namespace Demo.Data
{
    public class DemoDataService : IDemoDataService
    {
        public IEnumerable<Employee> RetrieveEmployees()
        {
          
            using (var context = new DemoEntities())
            {
                return context.Employees.ToList();
            }
        }
    }
}
