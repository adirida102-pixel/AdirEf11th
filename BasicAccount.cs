using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdirEf11th
{
    public class BasicAccount
    {
        private int bankNum;
        private int branchNum;
        private int accountNum;
        private string accountID;
        protected double balance;

        public static void BasicAccount_UT()
        {
            //BasicAccount a = new BasicAccount(0, 0, 0, "0");
            //Console.WriteLine(a.GetBalance());
            //Console.WriteLine(a.Deposit(1000000));
            //Console.WriteLine(a.GetBalance());
            //Console.WriteLine(a.AtRisk());
        }

        public BasicAccount(int bankNum, int branchNum, int accountNum, string accountID)
        {
            this.bankNum = bankNum;
            this.branchNum = branchNum;
            this.accountNum = accountNum;
            this.accountID = accountID;
            this.balance = 0;
        }

        public int GetBankNum()
        {
            return this.bankNum;
        }

        public int GetBranchNum()
        {
            return this.branchNum;
        }

        public int GetAccountNum()
        {
            return this.accountNum;
        }

        public string GetAccountID()
        {
            return this.accountID;
        }

        public double GetBalance()
        {
            return this.balance;
        }

        public void SetBalance(double balance)
        {
            this.balance = balance;
        }

        public virtual bool Deposit(int num)
        {
            bool success = false;
            if (num > 0)
            {
                this.balance += num;
                success = true;
            }
            return success;
        }

        public virtual bool AtRisk()
        {
            return false;
        }

        public override string ToString()
        {
            string savingString = $"Bank number: {this.GetBankNum()}\nBranch number: {this.GetBranchNum()}\nAccount number: {this.GetAccountNum()}\nAccount ID: {this.GetAccountID()}\nBalance: {this.GetBalance()}";
            return savingString;
        }
    }
}
