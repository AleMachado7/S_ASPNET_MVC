using System.ComponentModel.DataAnnotations;

namespace SalesMVC.Models
{
    public class Seller
    {
        public Guid Id { get; set; }

        [MaxLength(255)]
        public string Name { get; set; }

        [MaxLength(255)]
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double Salary { get; set; }
        public Guid DepartmentId { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller() { }

        public Seller(Guid id, string name, string email, DateTime birthDate, double salary, Guid departmentId)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            Salary = salary;
            DepartmentId = departmentId;
        }

        public void AddSale(SalesRecord sale)
        {
            Sales.Add(sale);
        }

        public void RemoveSale(SalesRecord sale)
        {
            Sales.Remove(sale);
        }

        public double TotalSales(DateTime initialDate, DateTime endDate)
        {
            return Sales.Where(sale => sale.Date >= initialDate && sale.Date <= endDate).Sum(sale => sale.Amount);
        }
    }
}
