using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdirEf11th
{
    public class CheckingAccount : BasicAccount
    {
        const double DEFAULT_OVERDRAFT = 1000;

        private double overdraft;

        public static void CheckingAccount_UT()
        {
            //CheckingAccount a1 = new CheckingAccount(1, 1, 1, "1");
            //CheckingAccount a2 = new CheckingAccount(2, 2, 2, "2", 100);
            //Console.WriteLine(a1);
            //Console.WriteLine(a1.Deposit(100));
            //Console.WriteLine(a1);
            //Console.WriteLine(a1.Withdrawal(500));
            //Console.WriteLine(a1);
            //Console.WriteLine(a1.Withdrawal(500));
            //Console.WriteLine(a1);
            //Console.WriteLine(a1.Withdrawal(500));
            //Console.WriteLine(a1);
            //Console.WriteLine(a2);
            //Console.WriteLine(a2.Deposit(300));
            //Console.WriteLine(a2);
            //Console.WriteLine(a2.Withdrawal(500));
            //Console.WriteLine(a2);
            //Console.WriteLine(a2.Withdrawal(200));
            //Console.WriteLine(a2);
        }

        public CheckingAccount(int bankNum, int branchNum, int accountNum, string accountID)
            : base(bankNum, branchNum, accountNum, accountID)
        {
            this.overdraft = CheckingAccount.DEFAULT_OVERDRAFT;
        }

        public CheckingAccount(int bankNum, int branchNum, int accountNum, string accountID, double overdraft)
            : base(bankNum, branchNum, accountNum, accountID)
        {
            this.overdraft = overdraft;
        }

        public double GetOverdraft()
        {
            return this.overdraft;
        }

        public void SetOverdraft(int overdraft)
        {
            if (overdraft >= 0)
            {
                this.overdraft = overdraft;
            }
        }

        public bool Withdrawal(int num)
        {
            bool success = false;
            if (num > 0 && this.balance - num > -1 * this.overdraft)
            {
                this.balance -= num;
                success = true;
            }
            return success;
        }

        //public bool Pay()
        //{

        //}

        public override string ToString()
        {
            string checkingString = $"{base.ToString()}\nOverdraft: {this.GetOverdraft()}";
            return checkingString;
        }
    }
}