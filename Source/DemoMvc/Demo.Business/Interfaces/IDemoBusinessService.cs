using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Entity;

namespace Demo.Business.Interfaces
{
    public interface IDemoBusinessService
    {
        IEnumerable<Employee> RetrieveEmployees();
    }
}
