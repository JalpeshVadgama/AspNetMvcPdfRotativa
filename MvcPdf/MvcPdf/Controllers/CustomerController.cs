using MvcPdf.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MvcPdf.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            var imagePath = "profile.jpg";

            var customers = new List<Customer>()
            {
                new Customer {CustomerId = 1, FirstName = "Jalpesh", LastName = "Vadgama", ProfileImage = imagePath},
                new Customer {CustomerId = 1, FirstName = "Vishal", LastName = "Vadgama", ProfileImage = imagePath}
            };

            return View(customers);

        }
    }
}