using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AdirEf11th
{
    public class SavingAccount : BasicAccount, IComparable
    {
        private Date endDate;

        public static void SavingAccount_UT()
        {
            //SavingAccount a1 = new SavingAccount(1, 1, 1, "1", new Date(1, 1, 2030));
            //SavingAccount a2 = new SavingAccount(2, 2, 2, "2", new Date(2, 2, 2025));
            //Console.WriteLine(a1);
            //Console.WriteLine(a1.Deposit(500));
            //Console.WriteLine(a1);
            //Console.WriteLine(a1.Withdrawal(-200, new Date(1, 1, 1)));
            //Console.WriteLine(a1);
            //Console.WriteLine(a1.Withdrawal(400, new Date(11, 11, 11)));
            //Console.WriteLine(a1);
            //Console.WriteLine(a2);
            //Console.WriteLine(a2.Deposit(-1));
            //Console.WriteLine(a2);
            //Console.WriteLine(a2.Deposit(200));
            //Console.WriteLine(a2);
            //Console.WriteLine(a2.Withdrawal(222, new Date(2, 2, 2)));
            //Console.WriteLine(a2);
            //a2.SetEndDate(new Date(2, 2, 2222));
            //Console.WriteLine(a2);
            //Console.WriteLine(a1.AtRisk());
        }

        public SavingAccount(int bankNum, int branchNum, int accountNum, string accountID, Date endDate)
            : base(bankNum, branchNum, accountNum, accountID)
        {
            this.endDate = endDate;
        }

        public Date GetEndDate()
        {
            return this.endDate;
        }

        public class NumAndDate
        {
            private double num;
            private Date date;

            public NumAndDate(double num, Date date)
            {
                this.num = num;
                this.date = date;
            }

            public double GetNum() { return this.num; }
            public Date GetDate() { return this.date; }
            public void SetNum(double num) { this.num = num; }
            public void SetDate(Date date) { this.date = date; }
        }

        public override bool Withdrawal(object o)
        {
            bool success = false;
            NumAndDate nad;
            double num;
            Date date;

            if (o is NumAndDate)
            {
                nad = (NumAndDate)o;
                num = nad.GetNum();
                date = nad.GetDate();
                if (num > 0 && this.GetEndDate().CompareTo(date) != -1)
                {
                    this.balance -= num;
                    success = true;
                }
            }
            
            return success;
        }

        public override bool AtRisk()
        {
            bool risk = this.GetBalance() == 0;
            return risk;
        }

        public int CompareTo(object o)
        {
            SavingAccount sa;
            int result = 0;

            if (o is SavingAccount)
            {
                sa = (SavingAccount)o;
                result = this.GetEndDate().CompareTo(sa.GetEndDate());
            }

            return result;
        }

        public override string ToString()
        {
            string savingString = $"{base.ToString()}\nEnd date: {this.GetEndDate().ToString()}";
            return savingString;
        }
    }
}
