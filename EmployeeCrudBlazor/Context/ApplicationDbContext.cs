using EmployeeCrudBlazor.Data;
using Microsoft.EntityFrameworkCore;

namespace EmployeeCrudBlazor.Context
{
    public class ApplicationDbContext :DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {
            
        }

        public DbSet<Employee> Employees { set; get; }
       // public DbSet<DropDownDataModel> DropDownDataModels { get; set; }
    }
}
