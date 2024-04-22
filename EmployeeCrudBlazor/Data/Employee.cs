using System.ComponentModel.DataAnnotations;

namespace EmployeeCrudBlazor.Data
{
    public class Employee
    {
        [Key]
        public int Id { set; get; }

        public string? FirstName { set; get; }

        public string? MiddleName { set; get; }

        public string? LastName { set; get;  }

        public string FullName => $"{FirstName}  {MiddleName} {LastName}";

        public string? Address { set; get; }

        public string? PostalCode { set; get; }

        public string? Email { set; get; }

        public string? City { set; get; }

        public string? State { set; get; }                        

        public string? PhoneNumber { set; get; }

        public string? Designation { set; get; }
    }
}
