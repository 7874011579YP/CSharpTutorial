using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    // 1. Encapsulation with Validation
    public class Encpsulation
    {
        private decimal balance;

        public decimal Balance
        {
            get { return balance; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Balance cannot be negative.");
                balance = value;
            }
        }
    }
    //2. Read-Only Public Property(private set)
    public class Order
    {
        public int OrderId { get; private set; }
        public DateTime OrderDate { get; private set; }

        public Order(int orderId)
        {
            OrderId = orderId;
            OrderDate = DateTime.Now;
        }
    }

}
