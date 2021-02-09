using SalesAplication.Data;
using SalesAplication.Models;
using System.Collections.Generic;
using System.Linq;

namespace SalesAplication.Services
{
    public class DepartmentService
    {
        private readonly SalesAplicationContext _context;

        public DepartmentService(SalesAplicationContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
