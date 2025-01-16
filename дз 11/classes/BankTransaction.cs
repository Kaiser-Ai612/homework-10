using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_12.@classes
{
    internal class BankTransaction
    {
        public DateTime date { get; }
        public double sum { get; }

        public BankTransaction() { }
        public BankTransaction(double money)
        {
            sum = money;
            date = DateTime.Now;
        }
        public void Print()
        {
            Console.WriteLine($"сумма:{sum} \n время:{date}");
        }
    }
}
