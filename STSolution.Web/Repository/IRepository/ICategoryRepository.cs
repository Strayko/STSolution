using System.Collections.Generic;
using STSolution.Data.Models;

namespace STSolution.Data.Repository.IRepository
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}