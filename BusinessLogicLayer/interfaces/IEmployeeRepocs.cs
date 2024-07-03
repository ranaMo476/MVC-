using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.interfaces
{
    public interface IEmployeeRepocs : IGenericReporsitry<Employee>
    {
      IQueryable<Employee> GetEmployeesByAddress(string Address);
        IQueryable<Employee> GetEmployeesByName(string SearchValue);
    }
}
