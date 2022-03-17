using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MtRoseConsultingWebsite.ViewModels;
using MtRoseConsultingWebsite.Models;
using MtRoseConsultingWebsite.Data;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MtRoseConsultingWebsite.Controllers
{
    public class ContactController : Controller
    {
        private readonly ApplicationDbContext context;

        public ContactController(ApplicationDbContext dbContext)
        {
            context = dbContext;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ConsultationRequest()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ConsultationRequest(CRViewModel viewModel)
        {

            if (ModelState.IsValid)
            {
                ConsultationRequests cr = new();
                cr.Name = viewModel.Name;
                cr.Email = viewModel.Email;
                cr.PhoneNumber = viewModel.PhoneNumber;
                cr.About = viewModel.About;
                context.ConsultationRequests.Add(cr);
                context.SaveChanges();
                return View("ThankYou");

            }

            return View("ConsultationRequest", viewModel);
        }

        public IActionResult Faqs()
        {
            return View();
        }
    }
}

