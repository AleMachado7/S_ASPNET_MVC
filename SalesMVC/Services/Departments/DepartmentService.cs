using Microsoft.EntityFrameworkCore;
using SalesMVC.Data;
using SalesMVC.Models;

namespace SalesMVC.Services.Departments
{
    public class DepartmentService : IDepartmentService
    {
        private readonly SalesMVCContext _context;

        public DepartmentService(SalesMVCContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
