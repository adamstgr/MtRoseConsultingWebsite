using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
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

        [Authorize(Roles = "admin")]
        [HttpGet]
        public IActionResult CreateBlog()
        {
            return View();
        }

        [Authorize(Roles = "admin")]
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

        [Authorize(Roles = "admin")]
        [HttpGet]
        public IActionResult Edit(Guid blogId)
        {
            BlogPost blog = context.Blogs.Find(blogId);

            EditBlogViewModel viewModel = new EditBlogViewModel();

            viewModel.Id = blogId;
            viewModel.Title = blog.Title;
            viewModel.Content = blog.Content;
               

            return View("Edit", viewModel);
        }

        [Authorize(Roles = "admin")]
        [HttpPost]
        public IActionResult Edit(EditBlogViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                BlogPost blog = context.Blogs.Find(viewModel.Id);
                blog.Title = viewModel.Title;
                blog.Content = viewModel.Content;
                context.Blogs.Update(blog);
                context.SaveChanges();
                return RedirectToAction("Blogs");

            }

            return View("Edit", viewModel);
        }



    }
}

