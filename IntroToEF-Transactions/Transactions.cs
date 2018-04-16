using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToEF_Transactions
{
    class Transactions
    {
        public int ID { get; set; }
        public string Timestamp { get; set; }
        public string Action { get; set; }
        public int AccountNumber { get; set; }
        public decimal AmountChanged { get; set; }
        public decimal NewAmount { get; set; }
        
    }
}
