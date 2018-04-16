using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntroToEF_Transactions.Data;


namespace IntroToEF_Transactions
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbContext = new DataContext();

            //INSERT NEW ITEM

            /*var newWithdrawal = new Transactions
            {
                Timestamp = new DateTime(2018, 04, 16, 05, 56, 00, 00),
                Action = "Withdrawal",
                AccountNumber = 132424,
                AmountChanged = 5000,
                NewAmount = 15000
            };
            dbContext.Transactions.Add(newWithdrawal);
            dbContext.SaveChanges();*/

            Console.WriteLine("FIND ALL TRANSACTIONS FROM TODAY");

            var todaysTransactions = dbContext.Transactions.Where(t => t.Timestamp > DateTime.Today.Date);

            foreach (var trans in todaysTransactions)
            {
                Console.WriteLine($"{trans.Timestamp} | {trans.AccountNumber} | {trans.Action} | {trans.AmountChanged} | {trans.NewAmount}");
            }

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("FIND 10 MOST RECENT TRANSACTIONS FROM A GIVEN USER");

            var tenMostRecent = dbContext.Transactions.Where(t => t.Timestamp < DateTime.Now && t.AccountNumber == 576734).OrderByDescending(t => t.Timestamp).Take(10);

            foreach (var trans in tenMostRecent)
            {
                Console.WriteLine($"{trans.Timestamp} | {trans.AccountNumber} | {trans.Action} | {trans.AmountChanged} | {trans.NewAmount}");
            }

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("COUNT ALL TRANSACTIONS FOR A GIVEN DAY AND GIVEN USER");

            var countOfTransactions = dbContext.Transactions.Count(c => (c.Timestamp < new DateTime (2018, 03, 14, 23, 59, 00) && c.Timestamp > new DateTime (2018, 03, 13, 23, 59, 00) && (c.AccountNumber == 576734)));

            Console.WriteLine(countOfTransactions);


            Console.ReadLine();
        }
    }
}
