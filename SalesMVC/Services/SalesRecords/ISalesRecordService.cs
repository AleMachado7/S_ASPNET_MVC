using SalesMVC.Models;

namespace SalesMVC.Services.SalesRecords
{
    public interface ISalesRecordService
    {
        public Task<List<SalesRecord>> FindByDateAsync(DateTime? minDate, DateTime? maxDate);
    }
}
