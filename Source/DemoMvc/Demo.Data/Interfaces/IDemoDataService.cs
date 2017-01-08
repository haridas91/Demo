using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Entity;

namespace Demo.Data.Interfaces
{
    public interface IDemoDataService
    {
         IEnumerable<Employee> RetrieveEmployees();
    }
}
