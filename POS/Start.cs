using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS
{
    public static class Start
    {
        public static int price;
        public static long cardNumber;
        public static int cvv2;
        public static string date;
        public static int Password;
        public static void GetInformation()
        {
            Console.WriteLine("Hi Welcome To Our Shop");
            Console.WriteLine("Price?"); 
            price = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your Card Number:");
             cardNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter Your Card CVV2: ");
             cvv2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your Card Expiry Date In This Format: YY/MM");
             date = Console.ReadLine();
             Console.WriteLine("Enter Your Dynamic Password:");
             Password = int.Parse(Console.ReadLine());
        }
    }
}
