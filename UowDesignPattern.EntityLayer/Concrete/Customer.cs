using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UowDesignPattern.EntityLayer.Concrete
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string EMail { get; set; }
        public decimal Balance { get; set; }
        public BankAccountDetail BankAccountDetail { get; set; }
    }
}
