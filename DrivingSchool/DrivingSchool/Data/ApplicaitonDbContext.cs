using EmployeeCRUD.Models;
using InstructorCRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace InstructorCRUD.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Employee> Employee { get; set; }
    }
}