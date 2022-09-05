using System;
using System.Collections.Generic;
using System.Text;

namespace DeadLockDemo.Helper
{
    public class Account
    {
        public int ID { get; }
        private double Balance;
        public Account(int id, double balance)
        {
            ID = id;
            Balance = balance;
        }

        public void WithdrawMoney(double amount)
        {
            Balance -= amount;
        }
        public void DepositMoney(double amount)
        {
            Balance += amount;
        }
    }
}
