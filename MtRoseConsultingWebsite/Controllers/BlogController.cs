using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MtRoseConsultingWebsite.Data;
using MtRoseConsultingWebsite.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MtRoseConsultingWebsite.Controllers
{
    public class BlogController : Controller
    {
        private readonly ApplicationDbContext context;

        public BlogController(ApplicationDbContext dbContext)
        {
            context = dbContext;
        }

        // GET: /<controller>/
        public IActionResult Blogs()
        {
            List<BlogPost> blogs = new();
            blogs = context.Blogs.ToList();


            return View(blogs);
        }

        [HttpGet]
        public IActionResult CreateBlog()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateBlog(CreateBlogViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                BlogPost blogPost = new();
                blogPost.Title = viewModel.Title;
                blogPost.Content = viewModel.Content;
                blogPost.Created = DateTime.Now;
                context.Blogs.Add(blogPost);
                context.SaveChanges();
                return RedirectToAction("Blogs");

            }

            return View("CreateBlog", viewModel);
        }


    }
}

