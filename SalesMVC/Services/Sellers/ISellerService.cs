using SalesMVC.Models;

namespace SalesMVC.Services.Sellers
{
    public interface ISellerService
    {
        Seller FindById(Guid id);
        List<Seller> FindAll();
        void Insert(Seller seller);
        void Delete(Guid id);
    }
}
