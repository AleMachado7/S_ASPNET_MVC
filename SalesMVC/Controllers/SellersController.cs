using Microsoft.AspNetCore.Mvc;
using SalesMVC.Services.Sellers;

namespace SalesMVC.Controllers
{
    public class SellersController : Controller
    {

        private readonly ISellerService _sellerService;

        public SellersController(ISellerService sellerService)
        {
            _sellerService = sellerService;
        }

        public IActionResult Index()
        {
            var sellers = _sellerService.FindAll();
            return View(sellers);
        }
    }
}
