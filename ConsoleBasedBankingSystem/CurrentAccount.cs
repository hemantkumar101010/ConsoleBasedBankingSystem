using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBasedBankingSystem
{
    internal class CurrentAccount : Account
    {
        public string acHolderName, bankName, cityName,acType;
        private int acNumber;
        
        
        //Providing implimentation for account class abstract methods
        public override void AcHolderDetails()
        {
            acHolderName = "Rahul";
            bankName = "PNB";
            cityName = "Delhi";
            acNumber = 230021203;
            acType = "Current Account";
            Console.WriteLine("Account Holder Name: " + acHolderName);
            Console.WriteLine("Bank name: " + bankName);
            Console.WriteLine("City Name: " + cityName);
            Console.WriteLine("Account Number " + acNumber);
            Console.WriteLine("Account Type: " + acType);
        }
        public override void MinAllowedBalance()
        {
            Console.WriteLine("Min. allowed balance for current account : " + 0);
        }
        public override void TotalAllowedTransections()
        {
            Console.WriteLine("Number of transection is unlimited in current account type");
        }

        //overriding interestRate function 
        public override void InterestRate()
        {
            Console.WriteLine("Interest rate for current account type is 0% ");
        }
    }
}
