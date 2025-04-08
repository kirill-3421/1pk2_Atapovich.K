using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_21_09
{
    internal class Ticket
    {
        public int Number {  get; set; }
        public decimal Price { get; set; }
        public bool HasBaggage { get; set; }
        public bool IsBenefits { get; set; }

        public Ticket() { }

        public Ticket(int number, decimal price, bool hasBaggage, bool isBenefits)
        {
            Number = number;
            Price = price;
            HasBaggage = hasBaggage;
            IsBenefits = isBenefits;
        }
    }
}
