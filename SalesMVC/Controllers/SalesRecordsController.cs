using Microsoft.AspNetCore.Mvc;
using SalesMVC.Services.SalesRecords;

namespace SalesMVC.Controllers
{
    public class SalesRecordsController : Controller
    {
        private readonly ISalesRecordService _salesRecordService;

        public SalesRecordsController(ISalesRecordService salesRecordService)
        {
            _salesRecordService = salesRecordService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> SimpleSearch(DateTime? minDate, DateTime? maxDate)
        {
            if (!minDate.HasValue)
            {
                minDate = DateTime.MinValue;
            }

            if(!maxDate.HasValue)
            {
                maxDate = DateTime.MaxValue;
            }

            ViewData["maxDate"] = maxDate.Value.ToString("yyyy-MM-dd");
            ViewData["minDate"] = minDate.Value.ToString("yyyy-MM-dd");

            var result = await _salesRecordService.FindByDateAsync(minDate, maxDate);
            return View(result);
        }

        public IActionResult GroupingSearch()
        {
            return View();
        }
    }
}
