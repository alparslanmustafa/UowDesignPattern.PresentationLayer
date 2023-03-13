using Microsoft.AspNetCore.Mvc;
using UowDesignPattern.DataAccessLayer.Concrete;
using UowDesignPattern.EntityLayer.Concrete;

namespace UowDesignPattern.PresentationLayer.Controllers
{
    public class Default : Controller
    {
        Context context=new Context();

        public IActionResult Index()
        {
            context.Update(new Customer
            {
                CustomerId = 2,
                CustomerName = "Mehmet Ali",
                CustomerSurname = "Kurtulmuş",
                Balance = 10500
            });

            context.SaveChanges();

            context.Update(new Customer
            {
                CustomerId = 3,
                CustomerName = "Ayşenur",
                CustomerSurname = "Çuhacı",
                Balance = 11500
            });
            context.SaveChanges();
            return View();
        }
    }
}
