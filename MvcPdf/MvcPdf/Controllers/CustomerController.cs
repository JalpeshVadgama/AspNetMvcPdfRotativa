using MvcPdf.Models;
using Rotativa;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MvcPdf.Controllers
{
    public class CustomerController : Controller
    {
        private List<Customer> _customers;

        public CustomerController()
        {
            var imagePath = "profile.jpg";
            _customers = new List<Customer>()
            {
                new Customer {CustomerId = 1, FirstName = "Jalpesh", LastName = "Vadgama", ProfileImage = imagePath},
                new Customer {CustomerId = 1, FirstName = "Vishal", LastName = "Vadgama", ProfileImage = imagePath}
            };
        }

        // GET: Customer
        [HttpGet]
        public ActionResult Index()
        {
            return View(_customers);

        }


        public ActionResult Print()
        {
            return new ActionAsPdf("Index", _customers);
        }
    }
}