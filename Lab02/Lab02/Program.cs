using System;

namespace Lab02
{
    class Program
    {

        public static decimal Balance = 100.00M; 
        
        public static void Main(string[] args)
        {
            UserInterFace();
            Console.WriteLine("Goodbye");
        }

        public static void UserInterFace()
        {
            Console.WriteLine("Welcome! Please type the number associated with the action you wish to perform:");
            Console.WriteLine("1. View Balance");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Deposit");
            Console.WriteLine("4. Exit");
            string userInput = Console.ReadLine();
            if(userInput == "1")
            {
                ViewBalance();
            }
            if(userInput == "4")
            {
                return;
            }
        }

        public static decimal ViewBalance()
        {
            Console.WriteLine("View Balance");
            Console.WriteLine($"Current Balance: {Balance}");
            Console.Write("Press 4 to return to main menu");
            string userInput = Console.ReadLine();
            while(userInput != "4")
            {
                Console.Write("Press 4 to return to main menu: ");
                userInput = Console.ReadLine();
            }
            if (userInput == "4")
            {
                UserInterFace();
            }
            return Balance;
        }

        public static decimal Withdraw()
        {
            return 1.20M;
        }

        public static decimal Deposit()
        {
            return 1.20M;
        }
    }
}


//1. Create UserInterface Method
//  a. UserInterFace Welcome Message
//  b. UserInterface options
//      i. View Balance
//      ii. Withdraw
//      iii. Deposit
//      iv. Exit
