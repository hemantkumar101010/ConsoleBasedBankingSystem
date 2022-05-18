using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBasedBankingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SavingAccount objS = new SavingAccount();
            objS.AcHolderDetails();
            Console.WriteLine();

            objS.Withdraw();
            Console.WriteLine();

            objS.InterestRate();


            /*CurrentAccount objC = new CurrentAccount();
            objC.AcHolderDetails();
            objC.Withdraw();
            objC.InterestRate();
             */
        }
    }
}
