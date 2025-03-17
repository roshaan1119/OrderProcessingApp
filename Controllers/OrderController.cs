using Microsoft.AspNetCore.Mvc;
using OrderProcessingApp.Models;

namespace OrderProcessingApp.Controllers
{
    public class OrderController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ProcessOrder(decimal orderAmount, string customerType)
        {
            var order = OrderService.CalculateOrder(orderAmount, customerType);
            return View("Result", order);
        }
    }
}