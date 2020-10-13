using System.Collections.Generic;
using STSolution.Data.Models;
using STSolution.Data.Repository.IRepository;
using STSolution.Web.Services;

namespace STSolution.Web.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _appDbContext;

        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Category> AllCategories => _appDbContext.Categories;
    }
}