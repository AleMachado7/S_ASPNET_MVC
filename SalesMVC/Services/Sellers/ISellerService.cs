using SalesMVC.Models;

namespace SalesMVC.Services.Sellers
{
    public interface ISellerService
    {
        List<Seller> FindAll();
    }
}
