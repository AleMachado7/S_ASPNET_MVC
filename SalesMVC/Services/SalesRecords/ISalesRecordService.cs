﻿using SalesMVC.Models;

namespace SalesMVC.Services.SalesRecords
{
    public interface ISalesRecordService
    {
        public Task<List<SalesRecord>> FindByDateAsync(DateTime? minDate, DateTime? maxDate);
        public Task<List<IGrouping<Department, SalesRecord>>> FindByDateGroupingAsync(DateTime? minDate, DateTime? maxDate);
    }
}
