using SalesMVC.Models;

namespace SalesMVC.Services.Sellers
{
    public interface ISellerService
    {
        Task<Seller> FindByIdAsync(Guid id);
        Task<List<Seller>> FindAllAsync();
        Task InsertAsync(Seller seller);
        Task DeleteAsync(Guid id);
        Task UpdateAsync(Seller seller);
    }
}
