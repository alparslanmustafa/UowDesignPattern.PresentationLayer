using Microsoft.AspNetCore.Mvc;
using System.Linq;
using UowDesignPattern.BusinessLayer.Abstract;
using UowDesignPattern.DataAccessLayer.Concrete;
using UowDesignPattern.EntityLayer.Concrete;
using UowDesignPattern.PresentationLayer.Models;

namespace UowDesignPattern.PresentationLayer.Controllers
{
    public class CustomerController : Controller
    {
        ICustomerService _customerservice;

        public CustomerController(ICustomerService customerservice)
        {
            _customerservice = customerservice;
        }

        [HttpGet]
        public IActionResult SendMoney()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SendMoney(ProcessViewModel p)
        {
            Context context = new Context();

            decimal senderCurrentBalance = context.Customers.Where(x => x.CustomerId == p.SenderID).Select(y => y.Balance).FirstOrDefault();

            decimal receiverCurrentBalance = context.Customers.Where(x => x.CustomerId == p.ReceiverID).Select(y => y.Balance).FirstOrDefault();

            p.SenderNewBalance = senderCurrentBalance - p.Amount;
            p.ReceiverNewBalance = receiverCurrentBalance + p.Amount;

            // Customer t = new Customer();

            var value1 = new Customer()
            {
                CustomerId = p.SenderID,
                Balance = p.SenderNewBalance
            };

            var value2 = new Customer()
            {
                CustomerId = p.ReceiverID,
                Balance = p.ReceiverNewBalance
            };

            //  _customerService.TUpdate(t);

            return View();
        }
    }
}
