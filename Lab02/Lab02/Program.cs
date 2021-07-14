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
            Console.Write("Please choose an action to perform: ");
            string menuInput = Console.ReadLine();
            //------------------------------------------View Balance----------------------------------------
            if(menuInput == "1")
            {
                Console.WriteLine("View Balance");
                Console.WriteLine($"Current Balance: {ViewBalance()}");
                Console.Write("Press 4 to return to main menu: ");
                string balanceInput = Console.ReadLine();
                while (balanceInput != "4")
                {
                    Console.Write("Press 4 to return to main menu: ");
                    balanceInput = Console.ReadLine();
                }
                if (balanceInput == "4")
                {
                    Console.Clear();
                    UserInterFace();
                }
            }
            //---------------------------------------Withdraw------------------------------------------------
            if(menuInput == "2")
            {
                Console.WriteLine("Withdraw Funds");
                Console.WriteLine($"Current Balance: {Balance}");
                Console.Write("Press 1 to withdraw or 4 to exit to main menu: ");
                string withdrawInput = Console.ReadLine();
                while(withdrawInput != "1" && withdrawInput != "4")
                {
                    Console.Write("Invalid option, please press 1 or 4: ");
                    withdrawInput = Console.ReadLine();
                }
                if(withdrawInput == "4")
                {
                    Console.Clear();
                    UserInterFace();
                }
                if (withdrawInput == "1")
                {
                    Console.Write("Amount: ");
                    decimal withdrawalAmount = Convert.ToDecimal(Console.ReadLine());
                    while (withdrawalAmount > Balance || withdrawalAmount < 0)
                    {
                        Console.WriteLine("Error: insufficient funds");
                        Console.Write("Amount: ");
                        withdrawalAmount = Convert.ToDecimal(Console.ReadLine());
                    }
                    Withdraw(withdrawalAmount);
                    Console.WriteLine($"{withdrawalAmount} withdrawn.");
                    Console.WriteLine($"Press 4 to return to menu");
                    withdrawInput = Console.ReadLine();
                    while(withdrawInput != "4")
                    {
                        Console.WriteLine($"Press 4 to return to menu");
                        withdrawInput = Console.ReadLine();
                    }
                    Console.Clear();
                    UserInterFace();
                }
            }
            //------------------------------------------------------Deposit-------------------------------------------
            if(menuInput == "3")
            {
                Console.WriteLine("Deposit Funds");
                Console.WriteLine($"Current Balance: {Balance}");
                Console.Write("Press 1 to deposit or 4 to exit to main menu: ");
                string depositInput = Console.ReadLine();
                while (depositInput != "1" && depositInput != "4")
                {
                    Console.Write("Invalid option, please press 1 or 4: ");
                    depositInput = Console.ReadLine();
                }
                if (depositInput == "4")
                {
                    Console.Clear();
                    UserInterFace();
                }
                if (depositInput == "1")
                {
                    Console.Write("Amount: ");
                    decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
                    while (depositAmount < 0)
                    {
                        Console.WriteLine("Error: incorrect value");
                        Console.Write("Amount: ");
                        depositAmount = Convert.ToDecimal(Console.ReadLine());
                    }
                    Deposit(depositAmount);
                    Console.WriteLine($"{depositAmount} deposited.");
                    Console.WriteLine($"Press 4 to return to menu");
                    depositInput = Console.ReadLine();
                    while (depositInput != "4")
                    {
                        Console.WriteLine($"Press 4 to return to menu");
                        depositInput = Console.ReadLine();
                    }
                    Console.Clear();
                    UserInterFace();
                }
            }
            //--------------------------------------------------------Exit-------------------------------------
            if(menuInput == "4")
            {
                return;
            }
        }

        public static decimal ViewBalance()
        {
            return Balance;
        }

        public static decimal Withdraw(decimal number)
        {
            Balance -= number;
            return Balance;
        }

        public static decimal Deposit(decimal number)
        {
            Balance += number;
            return Balance;
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
