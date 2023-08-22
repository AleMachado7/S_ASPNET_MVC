using SalesMVC.Models;
using SalesMVC.Models.Enums;

namespace SalesMVC.Data
{
    public class SeedingService
    {
        private readonly SalesMVCContext _context;

        public SeedingService(SalesMVCContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() ||
                _context.Seller.Any() ||
                _context.SalesRecord.Any()) { return; }


            Department d1 = new Department(Guid.NewGuid(), "Eletronics");
            Department d2 = new Department(Guid.NewGuid(), "Clothes");
            Department d3 = new Department(Guid.NewGuid(), "Sports and Outdoors");
            Department d4 = new Department(Guid.NewGuid(), "Beauty");
            Department d5 = new Department(Guid.NewGuid(), "Accessories");

            Seller s1 = new Seller(Guid.NewGuid(), "John Doe", "johndoe@gmail.com", new DateTime(1994, 7, 13), 2000.00, d1);
            Seller s2 = new Seller(Guid.NewGuid(), "Jane Smith", "janesmith@gmail.com", new DateTime(1990, 5, 25), 1800.00, d2);
            Seller s3 = new Seller(Guid.NewGuid(), "Michael Johnson", "michaeljohnson@gmail.com", new DateTime(1988, 9, 8), 2200.00, d3);
            Seller s4 = new Seller(Guid.NewGuid(), "Emily Brown", "emilybrown@gmail.com", new DateTime(1992, 11, 18), 1900.00, d4);
            Seller s5 = new Seller(Guid.NewGuid(), "David Wilson", "davidwilson@gmail.com", new DateTime(1996, 3, 4), 2100.00, d5);

            SalesRecord sr1 = new SalesRecord(Guid.NewGuid(), new DateTime(2019, 09, 25), 13000.00, SaleStatus.Billed, s1);
            SalesRecord sr2 = new SalesRecord(Guid.NewGuid(), new DateTime(2020, 02, 07), 9000.00, SaleStatus.Pending, s3);
            SalesRecord sr3 = new SalesRecord(Guid.NewGuid(), new DateTime(2021, 08, 15), 16500.00, SaleStatus.Canceled, s1);
            SalesRecord sr4 = new SalesRecord(Guid.NewGuid(), new DateTime(2022, 05, 10), 10750.00, SaleStatus.Billed, s3);
            SalesRecord sr5 = new SalesRecord(Guid.NewGuid(), new DateTime(2023, 01, 30), 14250.00, SaleStatus.Pending, s4);
            SalesRecord sr6 = new SalesRecord(Guid.NewGuid(), new DateTime(2024, 12, 05), 9800.00, SaleStatus.Pending, s5);
            SalesRecord sr7 = new SalesRecord(Guid.NewGuid(), new DateTime(2025, 06, 20), 12600.00, SaleStatus.Billed, s1);
            SalesRecord sr8 = new SalesRecord(Guid.NewGuid(), new DateTime(2026, 09, 14), 15200.00, SaleStatus.Pending, s5);
            SalesRecord sr9 = new SalesRecord(Guid.NewGuid(), new DateTime(2027, 07, 03), 11500.00, SaleStatus.Canceled, s1);
            SalesRecord sr10 = new SalesRecord(Guid.NewGuid(), new DateTime(2028, 03, 28), 9300.00, SaleStatus.Billed, s5);
            SalesRecord sr11 = new SalesRecord(Guid.NewGuid(), new DateTime(2029, 11, 12), 17800.00, SaleStatus.Billed, s4);
            SalesRecord sr12 = new SalesRecord(Guid.NewGuid(), new DateTime(2030, 08, 09), 10450.00, SaleStatus.Billed, s5);
            SalesRecord sr13 = new SalesRecord(Guid.NewGuid(), new DateTime(2031, 04, 02), 13600.00, SaleStatus.Pending, s1);
            SalesRecord sr14 = new SalesRecord(Guid.NewGuid(), new DateTime(2032, 10, 17), 12200.00, SaleStatus.Canceled, s5);
            SalesRecord sr15 = new SalesRecord(Guid.NewGuid(), new DateTime(2033, 03, 22), 15500.00, SaleStatus.Billed, s4);
            SalesRecord sr16 = new SalesRecord(Guid.NewGuid(), new DateTime(2034, 01, 11), 8900.00, SaleStatus.Billed, s5);
            SalesRecord sr17 = new SalesRecord(Guid.NewGuid(), new DateTime(2035, 09, 03), 13300.00, SaleStatus.Pending, s1);
            SalesRecord sr18 = new SalesRecord(Guid.NewGuid(), new DateTime(2036, 12, 30), 11000.00, SaleStatus.Billed, s5);
            SalesRecord sr19 = new SalesRecord(Guid.NewGuid(), new DateTime(2037, 06, 25), 14800.00, SaleStatus.Pending, s4);
            SalesRecord sr20 = new SalesRecord(Guid.NewGuid(), new DateTime(2038, 02, 19), 12050.00, SaleStatus.Billed, s5);
            SalesRecord sr21 = new SalesRecord(Guid.NewGuid(), new DateTime(2039, 08, 14), 16700.00, SaleStatus.Billed, s1);
            SalesRecord sr22 = new SalesRecord(Guid.NewGuid(), new DateTime(2040, 11, 09), 9500.00, SaleStatus.Pending, s5);
            SalesRecord sr23 = new SalesRecord(Guid.NewGuid(), new DateTime(2041, 07, 04), 14200.00, SaleStatus.Billed, s4);
            SalesRecord sr24 = new SalesRecord(Guid.NewGuid(), new DateTime(2042, 03, 01), 11500.00, SaleStatus.Pending, s5);
            SalesRecord sr25 = new SalesRecord(Guid.NewGuid(), new DateTime(2043, 09, 24), 12900.00, SaleStatus.Billed, s1);
            SalesRecord sr26 = new SalesRecord(Guid.NewGuid(), new DateTime(2044, 01, 18), 11000.00, SaleStatus.Canceled, s5);
            SalesRecord sr27 = new SalesRecord(Guid.NewGuid(), new DateTime(2045, 10, 13), 16000.00, SaleStatus.Pending, s4);
            SalesRecord sr28 = new SalesRecord(Guid.NewGuid(), new DateTime(2046, 05, 08), 9500.00, SaleStatus.Billed, s5);
            SalesRecord sr29 = new SalesRecord(Guid.NewGuid(), new DateTime(2047, 02, 02), 12300.00, SaleStatus.Billed, s1);
            SalesRecord sr30 = new SalesRecord(Guid.NewGuid(), new DateTime(2048, 12, 27), 13500.00, SaleStatus.Billed, s5);


            _context.Department.AddRange(d1, d2, d3, d4, d5);
            _context.Seller.AddRange(s1, s2, s3, s4, s5);
            _context.SalesRecord.AddRange(
                sr1, sr2, sr3, sr4, sr5, sr6, sr7, sr8, sr9, sr10,
                sr11, sr12, sr13, sr14, sr15, sr16, sr17, sr18, sr19, sr20,
                sr21, sr22, sr23, sr24, sr25, sr26, sr27, sr28, sr29, sr30
            );

            _context.SaveChanges();
        }
    }
}
