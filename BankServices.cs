using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdirEf11th
{
    public class BankServices
    {
        private BasicAccount[] accounts;

        public static void BankServices_UT()
        {
            BasicAccount[] accounts = new BasicAccount[5];
            BankServices services = new BankServices(accounts, 2);
            //Console.WriteLine(services);
            accounts[0] = new BasicAccount(0, 0, 0, "0");
            services.SetAccounts(accounts);
            //Console.WriteLine(services);
            BasicAccount a1 = new BasicAccount(22, 22, 22, "22");
            services.Add(a1);
            //Console.WriteLine(services.Add(a1));
            //Console.WriteLine(services);
            //Console.WriteLine(services.ShowAccountInfo(22));
            BasicAccount a2 = new BasicAccount(34, 56, 789, "22");
            services.Add(a2);
            //Console.WriteLine(services.OwnerAccountCount(789));
            //BasicAccount[] accs22 = services.AllOwnerAccounts("22");
            //for (int i = 0; i < accs22.Length; i++)
            //{
            //    Console.WriteLine(accs22[i]);
            //}
        }

        public BankServices(BasicAccount[] accounts, int size)
        {
            this.accounts = accounts;
        }

        public BasicAccount[] GetAccounts()
        {
            return this.accounts;
        }

        public void SetAccounts(BasicAccount[] accounts)
        {
            this.accounts = accounts;
        }

        public bool Add(BasicAccount account)
        {
            bool added = false;

            for (int i = 0; i < this.GetAccounts().Length; i++)
            {
                if (!added && this.GetAccounts()[i] == null)
                {
                    this.GetAccounts()[i] = account;
                    added = true;
                }
            }

            return added;
        }

        public string ShowAccountInfo(int accountNum)
        {
            string info = "";
            BasicAccount crntAcc;
            int crntAccNum = 0;

            for (int i = 0; i < this.GetAccounts().Length; i++)
            {
                crntAcc = this.GetAccounts()[i];
                if (crntAcc != null)
                {
                    crntAccNum = crntAcc.GetAccountNum();
                    if (crntAccNum == accountNum)
                    {
                        info = crntAcc.ToString();
                    }
                }
            }

            return info;
        }

        public int OwnerAccountCount(int accountNum)
        {
            int accCount = 0;
            BasicAccount crntAcc;
            int crntAccNum = 0;
            string accID = "";
            string crntAccID = "";

            for (int i = 0; i < this.GetAccounts().Length; i++)
            {
                crntAcc = this.GetAccounts()[i];
                if (crntAcc != null)
                {
                    crntAccNum = crntAcc.GetAccountNum();
                    if (crntAccNum == accountNum)
                    {
                        accID = crntAcc.GetAccountID();
                    }
                }
            }

            if (accID == "")
            {
                return 0;
            }

            for (int i = 0; i < this.GetAccounts().Length; i++)
            {
                crntAcc = this.GetAccounts()[i];
                if (crntAcc != null)
                {
                    crntAccID = crntAcc.GetAccountID();
                    if (crntAccID == accID)
                    {
                        accCount++;
                    }
                }
            }

            return accCount;
        }

        public BasicAccount[] AllOwnerAccounts(string accountID)
        {
            BasicAccount[] ownerAccs;
            int accCount = 0;
            BasicAccount crntAcc;
            string crntAccID = "";
            int accIndex = 0;

            for (int i = 0; i < this.GetAccounts().Length; i++)
            {
                crntAcc = this.GetAccounts()[i];
                if (crntAcc != null)
                {
                    crntAccID = crntAcc.GetAccountID();
                    if (crntAccID == accountID)
                    {
                        accCount++;
                    }
                }
            }

            if (accCount == 0)
            {
                return null;
            }
            else
            {
                ownerAccs = new BasicAccount[accCount];
            }

            for (int i = 0; i < this.GetAccounts().Length; i++)
            {
                crntAcc = this.GetAccounts()[i];
                if (crntAcc != null)
                {
                    crntAccID = crntAcc.GetAccountID();
                    if (crntAccID == accountID)
                    {
                        ownerAccs[accIndex] = crntAcc;
                        accIndex++;
                    }
                }
            }

            return ownerAccs;
        }

        public override string ToString()
        {
            string str = "";

            for (int i = 0; i < this.GetAccounts().Length; i++)
            {
                if (this.GetAccounts()[i] != null)
                {
                    str += this.GetAccounts()[i].ToString() + "\n\n";
                }
                else
                {
                    str += "No account found.\n\n";
                }
            }

            return str;
        }
    }
}
