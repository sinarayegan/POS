using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS
{
    internal class Program
    {

        static void Main(string[] args)
        {
            System.IO.Directory.CreateDirectory(@"C:\transactions");
            Start.GetInformation();
           Check.CheckCard(Start.cardNumber);
           Main(args);
        }
    }
}
