using System.Web.Mvc;
using TemplatedHelperMethods.Models;

namespace TemplatedHelperMethods.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult CreateCustomer()
        {
            return View(new Customer());
        }

        [HttpPost]
        public ActionResult CreateCustomer(Customer customer)
        {
            return View("DisplayCustomer", customer);
        }
    }
}