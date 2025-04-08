using System.Globalization;

namespace Task_21_09
{
    internal class Program
    {
        /*
           создайте класс билета (Ticket). сгенерируйте список из 30 билетов. произведите:
              • поиск билета с максимальной суммой, 
              • билета с минимальной суммой,
              • выведите список билетов с багажом
              • выведите список люготных билетов
         */

        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture =  new CultureInfo("us-US");
            Random rnd = new Random();
            List<Ticket> tickets = new List<Ticket>();

            for (int i = 0; i <= 30; i++)
            {
                decimal price = (decimal)(rnd.NextDouble() * 100);
                bool hasBaggage = rnd.Next(2) == 0;
                bool isBenifits = rnd.Next(2) == 0;

                tickets.Add(new Ticket(i, price, hasBaggage, isBenifits));
            }

            Ticket maxTicket = null;
            decimal maxPrice = 0;

            foreach (Ticket ticket in tickets)
            {
                if (ticket.Price > maxPrice)
                {
                    maxPrice = ticket.Price;
                    maxTicket = ticket;
                }
            }

            Ticket minTicket = null;
            decimal minPrice = decimal.MaxValue;

            foreach (Ticket ticket in tickets)
            {
                if (ticket.Price < minPrice)
                {
                    minPrice = ticket.Price;
                    minTicket = ticket;
                }
            }

            List<Ticket> ticketsWithBaggage = new List<Ticket>();
            foreach (Ticket ticket in tickets)
            {
                if (ticket.HasBaggage)
                {
                    ticketsWithBaggage.Add(ticket);
                }
            }

            List<Ticket> benefitsTickets = new List<Ticket>();
            foreach (Ticket ticket in tickets)
            {
                if (ticket.IsBenefits)
                {
                    benefitsTickets.Add(ticket);
                }
            }

            Console.Write("Билет с максимальной суммой - ");
            Console.WriteLine($"Билет №{maxTicket.Number}:\nЦена - {maxTicket.Price:C}\nБагаж - {maxTicket.HasBaggage}\nЛьготы - {maxTicket.IsBenefits}\n");

            Console.Write("Билет с минимальной суммой - ");
            Console.WriteLine($"Билет №{minTicket.Number}:\nЦена - {minTicket.Price:C}\nБагаж - {minTicket.HasBaggage}\nЛьготы - {minTicket.IsBenefits}\n");

            Console.WriteLine("Список билетов с багажов: ");
            foreach (var ticket in ticketsWithBaggage)
            {
                Console.WriteLine($"Билет №{ticket.Number}:\nЦена - {ticket.Price:C}\nБагаж - {ticket.HasBaggage}\nЛьготный - {ticket.IsBenefits}\n");

                Console.WriteLine("\nСписок льготных билетов:");
                foreach (var ticke in benefitsTickets)
                {
                    Console.WriteLine($"Билет №{ticke.Number}:\nЦена - {ticke.Price:C}\nБагаж - {ticke.HasBaggage},\nЛьготный - {ticke.IsBenefits} \n");
                }
            }
        }
    }
}
