using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using лаба_12.@enum;

namespace лаба_12.@classes
{
    internal class Bank
    {
        private uint id;
        private static uint idgen;
        public double balance;
        private accType? accType1 = null;
        //dz 8
        private Queue<BankTransaction>? tran;
        //
        // dz 8
        //
        public Bank() { this.id = IdGen(); }
        public Bank(double balance)
        {
            this.balance = balance;
            this.id = IdGen();
        }
        public Bank(accType acc)
        {
            accType1 = acc;
            this.id = IdGen();
        }
        public Bank(uint num,double balance, accType accType1)
        {
            this.id = num;
            this.balance = balance;
            this.accType1 = accType1;
        }
        public Bank(double balance, accType accType1)
        {
            this.id = IdGen();
            this.balance = balance;
            this.accType1 = accType1;
        }
        //
        private uint IdGen()
        {
            idgen++;
            return idgen;
        }
        //daz 8 
        public void Snyat(double a)
        {
            if (tran == null)
            {
                tran = new Queue<BankTransaction>();
            }
            if (a < balance && a > 0)
            {
                balance -= a;
                BankTransaction operate = new BankTransaction(a);
                tran.Enqueue(operate);
            }
        }
        public void Vnesty(double a)
        {
            if (tran == null)
            {
                tran = new Queue<BankTransaction>();
            }
            if (a > 0)
            {
                balance += a;
                BankTransaction operate = new BankTransaction(a);
                this.tran.Enqueue(operate);
            }
        }
        // дз 7
        //
        public bool Perevod(Bank bank, double summa)
        {
            try
            {
                this.Snyat(summa);
                bank.Vnesty(summa);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        //
        public void Print()
        {
            Console.WriteLine($"id:{id},\n баланс:{balance} ,тип счета :{accType1}");
        }
        //dz 10
        // Переопределение операторов
        public static bool operator ==(Bank b1, Bank b2)
        {
            if (ReferenceEquals(b1, b2)) return true;
            if (ReferenceEquals(b1, null) || ReferenceEquals(b2, null)) return false;
            return b1.id == b2.id && b1.balance == b2.balance && b1.accType1 == b2.accType1;
        }
        public static bool operator !=(Bank b1, Bank b2)
        {
            return !(b1 == b2);
        }

        //Equals
        public override bool Equals(object obj)
        {
            if (obj is Bank bank)
            {
                return this == bank;
            }
            return false;
        }
        //GetHashCode
        public override int GetHashCode()
        {
            return (int)(id ^ (balance.GetHashCode() * 13) ^ (accType1?.GetHashCode() ?? 0));//?? если вдруг тайп будет пустмы, то будет 0.умножаем на простой число чтобы избежать одинковых хэшов
        }
        // ToString
        public override string ToString()
        {
            return $"Bank ID: {id}, Balance: {balance}, Account Type: {accType1}";
        }
    }
}
