using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace POS
{
    static class Check
    {
        public static string workingDirectory = @"C:\cards\";
        public static string TransactionDirectory = @"C:\transactions\transactions.txt";
        public static List<string> cardDetails = new List<string>();
        private static int i=System.IO.File.ReadAllLines(TransactionDirectory).Length+1;

      
        public static void CheckCard(long cardNumber)
        {
            try
            {
                if (System.IO.File.Exists(workingDirectory + cardNumber + ".txt"))
                {
                    var content = File.ReadAllLines(workingDirectory + cardNumber + ".txt").ToList();
                    foreach (var x in content)
                    {
                        var delimiter = x.IndexOf(':');
                        cardDetails.Add(x.Substring(delimiter + 1));
                    }
                    var a = File.GetLastWriteTime(workingDirectory + cardNumber + ".txt");
                    TimeSpan t = DateTime.Now - a;
                    if (int.Parse(cardDetails[0]) == Start.cvv2 && (cardDetails[1]) == Start.date && int.Parse(cardDetails[2]) == Start.Password && t.TotalMinutes <= 2)
                    {

                        File.AppendAllText(TransactionDirectory, $"{i} -     Card:{cardNumber}     Price:{Start.price}    Status:Successful    Date And Time:{DateTime.Now}" + Environment.NewLine);
                        i++;
                        Console.WriteLine("Transaction Has Completed Successfully");
                    }
                    else
                    {
                        Failed(cardNumber);
                    }

                }
                else
                {
                     Failed(cardNumber);
                }
            }
            catch (Exception e)
            {
                Failed(cardNumber);
            }
            
        }
        public static void Failed(long cardNumber)
        {
            File.AppendAllText(TransactionDirectory, $"{i} -     Card:{cardNumber}     Price:{Start.price}     Status:Failed    Date And Time:{DateTime.Now}" + Environment.NewLine);
            i++;
            Console.WriteLine("Failed Transaction. Re-Check Your Card Information");

        }

    }
}