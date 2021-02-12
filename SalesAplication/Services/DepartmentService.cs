using Microsoft.EntityFrameworkCore;
using SalesAplication.Data;
using SalesAplication.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesAplication.Services
{
    public class DepartmentService
    {
        private readonly SalesAplicationContext _context;

        public DepartmentService(SalesAplicationContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
