using Microsoft.AspNetCore.Mvc;

namespace LSCargo.Web.Controllers
{
    public class PrototypeController : Controller
    {
        [Route("prototype/contact")]
        public IActionResult Contact()
        {
            return View("~/Views/Prototype/Contact.cshtml");
        }
    }
}