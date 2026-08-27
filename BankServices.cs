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
            //BasicAccount[] accounts = new BasicAccount[5];
            //BankServices services = new BankServices(accounts);
            //Console.WriteLine(services);
            //accounts[0] = new BasicAccount(0, 0, 0, "0");
            //services.SetAccounts(accounts);
            //Console.WriteLine(services);
            //BasicAccount a1 = new BasicAccount(22, 22, 22, "22");
            //services.Add(a1);
            //Console.WriteLine(services.Add(a1));
            //Console.WriteLine(services);
            //Console.WriteLine(services.ShowAccountInfo(22));
            //BasicAccount a2 = new BasicAccount(34, 56, 789, "22");
            //services.Add(a2);
            //Console.WriteLine(services.OwnerAccountCount(789));
            //BasicAccount[] accs22 = services.AllOwnerAccounts("22");
            //for (int i = 0; i < accs22.Length; i++)
            //{
            //    Console.WriteLine(accs22[i]);
            //}
            //accounts[0].Deposit(100);
            //accounts[1].Deposit(45);
            //accounts[2].Deposit(60);
            //Console.WriteLine(services.RichestPerson());
            //CheckingAccount ca = new CheckingAccount(2763, 2763, 2763, "4X", 100);
            //ca.Withdrawal(50);
            //services.Add(ca);
            //Console.WriteLine(ca.AtRisk());
            //BusinessAccount ba = new BusinessAccount(57, 35, 15, "5731", 10000, "bus");
            //ba.Withdrawal(9753.1);
            //services.Add(ba);
            //Console.WriteLine(ba.AtRisk());
            //BasicAccount[] riskList = services.RiskAccounts();
            //for (int i = 0; i < riskList.Length; i++)
            //{
            //    Console.WriteLine(riskList[i]);
            //}
        }

        public BankServices(BasicAccount[] accounts)
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

        public string RichestPerson()
        {
            int size = 0;
            BasicAccount crntAcc;
            string[] allIDs;
            double[] allBalances;
            int index = 0;
            double maxBalance;
            string richestID = "";

            for (int i = 0; i < this.GetAccounts().Length; i++)
            {
                crntAcc = this.GetAccounts()[i];
                if (crntAcc != null)
                {
                    size++;
                }
            }

            allIDs = new string[size];
            allBalances = new double[size];

            for (int i = 0; i < this.GetAccounts().Length; i++)
            {
                crntAcc = this.GetAccounts()[i];
                if (crntAcc != null)
                {
                    allIDs[index] = crntAcc.GetAccountID();
                    index++;
                }
            }

            index = 0;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < this.GetAccounts().Length; j++)
                {
                    crntAcc = this.GetAccounts()[j];
                    if (crntAcc != null)
                    {
                        if (crntAcc.GetAccountID() == allIDs[index])
                        {
                            allBalances[index] += crntAcc.GetBalance();
                        }
                    }
                }
                index++;
            }

            maxBalance = allBalances[0];
            richestID = allIDs[0];

            for (int i = 0; i < size; i++)
            {
                if (allBalances[i] > maxBalance)
                {
                    maxBalance = allBalances[i];
                    richestID = allIDs[i];
                }
            }

            return richestID;
        }

        public BasicAccount[] RiskAccounts()
        {
            int riskNum = 0;
            BasicAccount crntAcc;
            BasicAccount[] riskAccs;
            int index = 0;

            for (int i = 0; i < this.GetAccounts().Length; i++)
            {
                crntAcc = this.GetAccounts()[i];
                if (crntAcc != null)
                {
                    if (crntAcc.AtRisk())
                    {
                        riskNum++;
                    }
                }
            }

            riskAccs = new BasicAccount[riskNum];

            for (int i = 0; i < this.GetAccounts().Length; i++)
            {
                crntAcc = this.GetAccounts()[i];
                if (crntAcc != null)
                {
                    if (crntAcc.AtRisk())
                    {
                        riskAccs[index] = crntAcc;
                        index++;
                    }
                }
            }

            return riskAccs;
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
