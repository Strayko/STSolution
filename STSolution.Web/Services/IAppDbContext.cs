using Microsoft.EntityFrameworkCore;
using STSolution.Data.Models;

namespace STSolution.Web.Services
{
    public interface IAppDbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        int SaveChanges();
        void SetModified(object entity);
    }
}