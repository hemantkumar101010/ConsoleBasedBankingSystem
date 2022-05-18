using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBasedBankingSystem
{
    internal class SavingAccount : Account
    {
        //declaration of fields
       public string acHolderName, bankName, cityName, acType;
        private int acNumber;

        //Providing implimentation for account class abstract methods
        public override void AcHolderDetails()
        {
            acHolderName = "Hemant";
            bankName = "SBI";
            cityName = "Srinagar";
            acNumber = 23001203;
            acType = "Saving Account";
            Console.WriteLine("Account Holder Name: " + acHolderName);
            Console.WriteLine("Bank name: " + bankName);
            Console.WriteLine("City Name: " + cityName);
            Console.WriteLine("Account Number " + acNumber);
            Console.WriteLine("Account Type: " + acType);


        }
        public override void MinAllowedBalance()
        {
            Console.WriteLine("Min allowed balance for saving account is : " + 2000);
        }
        public override void TotalAllowedTransections()
        {
            Console.WriteLine("Number of transection is limited in saving account type");
        }

        //overiding interestRate function
        public override void InterestRate()
        {
            Console.WriteLine("Interest rate for saving account type is 4% ");
        }


    }
}
