using Microsoft.EntityFrameworkCore;

namespace dotnet_aspnet_crud_mvc.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
        : base(options)
        {

        }
        
    }
}