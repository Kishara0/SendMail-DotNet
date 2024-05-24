using Microsoft.AspNetCore.Mvc;

namespace SendMail.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SendMailController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
