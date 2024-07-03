using BusinessLogicLayer.interfaces;
using DataAccessLayer.Context;
using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Reprositres
{
    public class GenericReposatory<T> : IGenericReporsitry<T> where T : class 
   
    {
        private readonly MVCAPPDBContext _dbContext;
        public GenericReposatory(MVCAPPDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int Add(T item)
        {
            _dbContext.Add(item);
            return _dbContext.SaveChanges();
        }

        public int Delete(T item)
        {
            _dbContext.Remove(item);
            return _dbContext.SaveChanges();
        }

        public T Get(int id)
        {
            return _dbContext.Set<T>().Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            if (typeof(T) == typeof(Employee)) {
                return (IEnumerable<T>)_dbContext.Employees.Include(E => E.Department);
            }
            return _dbContext.Set<T>().ToList();
        }

        public int Update(T item)
        {
_dbContext.Update(item);    
            return _dbContext.SaveChanges();
                }
    }
}
