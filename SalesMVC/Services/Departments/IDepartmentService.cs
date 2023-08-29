using SalesMVC.Models;

namespace SalesMVC.Services.Departments
{
    public interface IDepartmentService
    {
        Task<List<Department>> FindAllAsync();
    }
}
