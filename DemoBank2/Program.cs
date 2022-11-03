// See https://aka.ms/new-console-template for more information

using System;

internal class Program
{
    private static void Main(string[] args)
    {
        bool repeat = false;


        do { 
        Console.WriteLine("AUTHENTICATION:\n> Press C for customer and S for staff");
        string AutResponse = Console.ReadLine();
        

        if (AutResponse.ToUpper() == "C")
        {
            Console.WriteLine(AutResponse);
        }
        else if (AutResponse.ToUpper() == "S")
        {
            Console.WriteLine("what should we do today\n1.Signup someone new!\n2. Get customer data\n3. Clear/Remove account");
                repeat = false;

                switch (Convert.ToInt32(Console.ReadLine()))
                    {
                    case int option when option == 1:
                        Console.WriteLine("CUSTOMER SIGNUP");
                        for (int i=0; i<=4; i++)
                        {
                            Console.WriteLine();
                            do
                            {

                                int j = 0;
                                if (j > 0) { Console.WriteLine("Null Response mot allowed, Retry"); }
                                string[] options = new string[5] { "name", "age", "password", "password again", "deposit" };
                                string[] exportOptions = new string[5];
                                Console.WriteLine($"Enter the customer's {options[i]} :");
                                if (Console.ReadLine() != "") { exportOptions[i] = Console.ReadLine(); }
                                j++;
                            }
                            while (Console.ReadLine() == "");


                        }

                        break;
                    case int option when option == 2:
                        Console.WriteLine(AutResponse);
                        break;
                    case int option when option == 3:
                        Console.WriteLine(AutResponse);
                        break;
                }
        }
        else
        {
            Console.WriteLine($"Expected S or C, instead got {AutResponse}; Seriously bro??\n>>DO you wish to retry? Y/N");
            if (Console.ReadLine() == "Y" || Console.ReadLine == null) {repeat = true; }
            else {repeat = false;}

        }
        }
        while (repeat == true);
    }
}