using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdirEf11th
{
    public class BusinessAccount : CheckingAccount
    {
        private string businessName;

        public static void BusinessAccount_UT()
        {
            //BusinessAccount a = new BusinessAccount(1, 2, 3, "444", 100, "bus");
            //Console.WriteLine(a.Withdrawal(90));
            //Console.WriteLine(a.AtRisk());
        }

        public BusinessAccount(int bankNum, int branchNum, int accountNum, string accountID, string businessName)
            : base(bankNum, branchNum, accountNum, accountID)
        {
            this.businessName = businessName;
        }

        public BusinessAccount(int bankNum, int branchNum, int accountNum, string accountID, double overdraft, string businessName)
            : base(bankNum, branchNum, accountNum, accountID, overdraft)
        {
            this.businessName = businessName;
        }

        public string GetBusinessName()
        {
            return this.businessName;
        }

        public void SetBusinessName(string businessName)
        {
            this.businessName = businessName;
        }

        public override bool AtRisk()
        {
            bool risk = this.GetBalance() <= -1 * 0.9 * this.GetOverdraft();
            return risk;
        }

        public override string ToString()
        {
            string businessString = $"{base.ToString()}\nBusiness name: {this.GetBusinessName()}";
            return businessString;
        }
    }
}