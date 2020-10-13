using System.Collections.Generic;
using STSolution.Data.Models;

namespace STSolution.Data.ViewModels
{
    public class BlogListViewModel
    {
        public IEnumerable<Blog> Blogs { get; set; }
        public string CurrentCategory { get; set; }
    }
}