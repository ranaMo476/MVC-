using BusinessLogicLayer.interfaces;
using DataAccessLayer.Context;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Reprositres
{
    public class EmployeeReposetary : GenericReposatory<Employee>, IEmployeeRepocs
    {
        private readonly MVCAPPDBContext _dbContext;
        public EmployeeReposetary(MVCAPPDBContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<Employee> GetEmployeesByAddress(string address)
        {
          return   _dbContext.Employees.Where(E => E.Address == address);
        }

        public IQueryable<Employee> GetEmployeesByName(string SearchValue)
        {
           return _dbContext.Employees.Where(E => E.Name.ToLower().Contains(SearchValue.ToLower()));
        }
    }
}
