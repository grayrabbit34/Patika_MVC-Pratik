using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NET_Core_MVC.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASP.NET_Core_MVC.Controllers
{
    public class CustomerOrdersController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var _customer = new Customer
            {
                Id = 1,
                FirstName = "Ali",
                LastName = "Kıran",
                Email = "xyx@gmail.com"
            };

            List<Order> _orders = new List<Order>
            {
                new Order
                {           Id = 1,
                            ProductName = "Televizyon",
                            Price = 12000,
                            Quantity = 2
                },
                new Order
                {
                    Id = 2,
                    ProductName = "Bilgisayar",
                    Price = 5000,
                    Quantity = 4
                }

            };

            var viewModel = new CustomerOrderViewModel
            {
                Customer = _customer,
                Orders = _orders,
            };

            return View(viewModel);
        }
    }
}

