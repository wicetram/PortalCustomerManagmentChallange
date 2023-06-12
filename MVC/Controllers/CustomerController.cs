using Microsoft.AspNetCore.Mvc;
using MVC.Business.Abstract;
using MVC.Models;

namespace MVC.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public IActionResult AddCustomer()
        {
            var customer = new Customer();
            return View(customer);
        }

        [HttpPost]
        public IActionResult AddCustomer(Customer customer)
        {
            try
            {
                var result = _customerService.AddCustomer(customer);
                if (result != null)
                {
                    TempData["Message"] = $"{customer.Name} {customer.Surname} is successfully completed";
                }
                else
                {
                    return BadRequest(string.Empty);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return RedirectToAction("CustomerList", "Home");

        }

        public IActionResult CustomerList()
        {
            var users = _customerService.GetAll();
            return View(users);
        }

        public IActionResult Success()
        {
            return View();
        }
    }
}
