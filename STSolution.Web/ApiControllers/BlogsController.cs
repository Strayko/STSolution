using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using STSolution.Data.Repository.IRepository;
using STSolution.Web.Repository.IRepository;

namespace STSolution.Web.ApiControllers
{
    [Route("api/[controller]")]
    public class BlogsController : ControllerBase
    {
        private readonly IBlogRepository _blogRepository;

        public BlogsController(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }
        
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var results = _blogRepository.AllBlogs;
                return Ok(results);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }
        }
    }
}