using BusinessLogicLayer.interfaces;
using DataAccessLayer.Context;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Reprositres
{
    public class DepartmentReposetary :GenericReposatory<Department>, IDepartmentRepo
    {
        private readonly MVCAPPDBContext _dbcontext ;

        public DepartmentReposetary(MVCAPPDBContext dbContext) : base(dbContext)
        {
        }
    }
}
