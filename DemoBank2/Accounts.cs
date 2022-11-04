using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBank2
{
    internal class Accounts
    {
        public class bankAccount
        {
            private string bankID = "254-12-2034";
            private string bankName = "National Bank - Meru";
            public string customerName;
            public string customerID;
            public string deposit;
            public string balance;
            private string password;

            public string BankID
            {
                get { return bankID; }
            }
            public string BankName
            {
                get { return bankName; }
            }
            public string Password { set { password = value; } }

        }
        public void newCustomer(string name, string age, string password, string deposit)
        {
            Console.WriteLine("response"+ name + age+ password+ deposit);
            int newAge = int.Parse(age);
            int newPassword = int.Parse(password);
            int newDeposit = int.Parse(deposit);
            string part1ID, part2ID, part3ID;
            if (newAge < 18) { part1ID = "Ch"; }
            else if( newAge>= 18 && newAge <=60) { part1ID = "Ud"; }
            else if(newAge> 40) { part1ID = "Re"; }

            if (newDeposit < 10000) { part2ID = "C"; }
            else if (newDeposit >= 10000 && newDeposit <= 70000) { part2ID = "B"; }
            else if (newDeposit > 70000 && newDeposit <= 200000) { part2ID = "A"; }
            else if (newDeposit > 200000) { part2ID = "Plat"; }

            //get the customer a new ID

        }
    }
}
