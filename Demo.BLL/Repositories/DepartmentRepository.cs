using Demo.BLL.Interfaces;
using Demo.DAL.Context;
using Demo.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly MVCAppGr03DbContext context;

        public DepartmentRepository(MVCAppGr03DbContext  context)
        {
            this.context=context;
        }

        public int Add(Department department)
        {
           context.departments.Add(department);
             return context.SaveChanges();
        }

        public int Delete(Department department)
        {
            context.departments.Remove(department);
            return context.SaveChanges();
        }

        public Department Get(int? id)
        => context.departments.FirstOrDefault(D => D.Id == id);

        public IEnumerable<Department> GetAll()
        => context.departments.ToList();

        public int Update(Department department)
        {
            context.departments.Update(department);
            return context.SaveChanges();
        }
    }
}
