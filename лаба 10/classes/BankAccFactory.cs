using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_11.classes
{
    internal class BankAccFactory
    {
        private Dictionary<string, BankAcc> accounts = new Dictionary<string, BankAcc>();
        private int accountCounter = 1;

        public string CreateAccount(decimal initialBalance)
        {
            string accountNumber = GenerateAccountNumber();
            BankAcc newAccount = new BankAcc(accountNumber, initialBalance);
            accounts[accountNumber] = newAccount;
            return accountNumber;
        }

        // перегрузка метода для 0 баланса
        public string CreateAccount()
        {
            return CreateAccount(0);
        }
        private string GenerateAccountNumber()
        {
            return accountCounter++.ToString();
        }
        public bool CloseAccount(string accountNumber)
        {
            return accounts.Remove(accountNumber);
        }
        public BankAcc GetAccount(string accountNumber)
        {
            accounts.TryGetValue(accountNumber, out BankAcc account);// проверяет существует ли такой аккаунт по ключ значению
            return account;
        }
    }
}
