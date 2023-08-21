using System.ComponentModel.DataAnnotations;

namespace SalesMVC.Models
{
    public class Department
    {
        public Guid Id { get; set; }

        [MaxLength(255)]
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department() { }

        public Department(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }

        public double TotalSales(DateTime initialDate, DateTime endDate)
        {
            return Sellers.Sum(seller => seller.TotalSales(initialDate, endDate));
        }
    }
}
