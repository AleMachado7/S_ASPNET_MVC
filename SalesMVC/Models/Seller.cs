using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace SalesMVC.Models
{
    public class Seller
    {
        public Guid Id { get; set; }

        [MaxLength(255)]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "{0} size should be at least {2} characteres")]
        [Required(ErrorMessage = "{0} is required")]
        public string Name { get; set; }

        [MaxLength(255)]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "{0} is required")]
        [RegularExpression(("^\\S+@\\S+\\.\\S+$"), ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; }

        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "{0} is required")]
        public DateTime BirthDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:F2}")]
        [Required(ErrorMessage = "{0} is required")]
        [Range(1000.0, 20000.0, ErrorMessage = "{0} must be from {1} to {2}")]
        public double Salary { get; set; }

        public Department? Department { get; set; }

        [Display(Name = "Department Name")]
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
