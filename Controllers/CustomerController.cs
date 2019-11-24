using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Customers()
        {
            CustomersViewModel customersVM = new CustomersViewModel();
            customersVM.Customers = new List<Customer>();
            customersVM.Customers.Add(new Customer { Id = 1, Name = "Nancy" });
            customersVM.Customers.Add(new Customer { Id = 2, Name = "Nice" });
            customersVM.Customers.Add(new Customer { Id = 3, Name = "Fionna" });



            return View(customersVM);
        }

        public ActionResult Details(int id)
        {
            List<Customer> Customers = new List<Customer>();
            Customers.Add(new Customer { Id = 1, Name = "Nancy" });
            Customers.Add(new Customer { Id = 2, Name = "Nice" });
            Customers.Add(new Customer { Id = 3, Name = "Fionna" });

            Customer customerDetail = Customers.Where(x => x.Id == id).FirstOrDefault();

            return View(customerDetail);
        }
    }
}