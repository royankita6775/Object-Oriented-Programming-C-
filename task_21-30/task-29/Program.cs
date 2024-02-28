using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PaidWithCash customer1 = new PaidWithCash()
            {
                Total = 27
            };
            Console.WriteLine("customer paid " + Total);

            PaidWithCash customer2 = new PaidWithCash()
            {
                Total = 33
            };
            Console.WriteLine("customer paid " + Total);

            PaidWithCard customer3 = new PaidWithCard()
            {
                Total = 35
            };
            Console.WriteLine("Transaction to bank: charge from card 0001-0002 date 1.12.2022 amount " + Total);

            PaidWithCard customer3 = new PaidWithCard()
            {
                Total = 55
            };
            Console.WriteLine("Transaction to bank: charge from card 0001-0002 date 1.12.2022 amount " + Total);
            Console.ReadKey();
        }

    }
    public class PaidWithCash
    {
        public int Total { get; set; }
        {
            return $"Transaction to bank: charge from card 0001-0002 date 1.12.2022 amount {Total}";
        }
}
public class PaidWithCard
{
    public int Payable { get; set; }
            {
                return $"Transaction to bank: charge from card 0001-0002 date 1.12.2022 amount {Total}";;
            }
    }

}
