
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
                cr.DateRequested = DateTime.Now;
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

        [Authorize(Roles = "admin")]
        [HttpGet]
        public IActionResult ViewRequests()
        {
            var list = context.ConsultationRequests.ToList();


            return View(list);
        }
    }
}

