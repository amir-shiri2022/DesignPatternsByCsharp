using System;

namespace NullObject.Sample1
{
    public class BankAccount
    {
        private ILog log;
        private int balance;

        public BankAccount(ILog log)
        {
            this.log = log;
        }

        public void Deposit(int amount)
        {
            balance += amount;
            log.Info($"desposited {amount} , balance is now {balance}");
        }
    }
}