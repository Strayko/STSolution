using System;
using Microsoft.AspNetCore.Mvc;
using STSolution.Data.Repository.IRepository;
using STSolution.Data.ViewModels;
using STSolution.Web.Repository.IRepository;

namespace STSolution.Web.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogRepository _blogRepository;
        private readonly ICategoryRepository _categoryRepository;

        public BlogController(IBlogRepository blogRepository, ICategoryRepository categoryRepository)
        {
            _blogRepository = blogRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult Index()
        {
            ViewBag.Current = "Blog";
            
            BlogListViewModel blogListViewModel = new BlogListViewModel();
            blogListViewModel.Blogs = _blogRepository.AllBlogs;

            Console.WriteLine(blogListViewModel);

            blogListViewModel.CurrentCategory = "PHP";
            return View(blogListViewModel);
        }

        public IActionResult Details(int id)
        {
            ViewBag.Current = "Blog";
            
            var blog = _blogRepository.GetBlogById(id);
            if (blog == null)
                return NotFound();
            return View(blog);
        }
    }
}