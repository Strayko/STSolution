using System.Collections.Generic;
using STSolution.Data.Models;

namespace STSolution.Data.Repository.IRepository
{
    public interface IBlogRepository
    {
        IEnumerable<Blog> AllBlogs { get; }
        Blog GetBlogById(int blogId);
        void Add(Blog blog);
        void Update(Blog blog);
        void Delete(int blogId);
    }
}