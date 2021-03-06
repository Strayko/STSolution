﻿using System.Linq;
using Microsoft.AspNetCore.Mvc;
using STSolution.Data.Repository.IRepository;
using STSolution.Web.Repository.IRepository;

namespace STSolution.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBlogRepository _blogRepository;

        public HomeController(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }

        public IActionResult Index()
        {
            ViewBag.Current = "Home";
            
            var blogs = _blogRepository.AllBlogs.OrderBy(b => b.Name);
            return View(blogs);
        }
    }
}