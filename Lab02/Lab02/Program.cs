using System;

namespace Lab02
{
    public class Program
    {

        public static decimal Balance = 100.00M; 
        
        public static void Main(string[] args)
        {
            UserInterFace();
            Console.WriteLine("Goodbye");
        }

        public static void UserInterFace()
        {
            Console.WriteLine("Welcome! Please type the number associated with the action you wish to perform:" +
                "\n1. View Balance " +
                "\n2. Withdraw " +
                "\n3. Deposit " +
                "\n4. Exit");
            Console.Write("Please choose an action to perform: ");
            string menuInput = Console.ReadLine();
            while (menuInput != "1" && menuInput != "2" && menuInput != "3" && menuInput != "4")
            {
                Console.Write("Input invalid. Please try again: ");
                menuInput = Console.ReadLine();
            }
            //------------------------------------------View Balance----------------------------------------
            if(menuInput == "1")
            {
                Console.Clear();
                Console.WriteLine("View Balance");
                Console.WriteLine($"Current Balance: {ViewBalance()}");
                ReturnHome();
            }
            //---------------------------------------Withdraw------------------------------------------------
            if(menuInput == "2")
            {
                Console.Clear();
                Console.WriteLine("Withdraw Funds");
                try
                {
                    Console.Write("Amount: ");
                    decimal withdrawalAmount = Convert.ToDecimal(Console.ReadLine());
                    Withdraw(withdrawalAmount);
                }
                catch(FormatException)
                {
                    Console.WriteLine("Invalid format");
                    ReturnHome();
                }
                ReturnHome();
            }
            //------------------------------------------------------Deposit-------------------------------------------
            if(menuInput == "3")
            {
                Console.Clear();
                Console.WriteLine("Deposit Funds");
                try
                {
                    Console.Write("Amount: ");
                    decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
                    Deposit(depositAmount);
                }
                catch(FormatException)
                {
                    Console.WriteLine("Invalid format");
                    ReturnHome();
                }
                ReturnHome();
            }
            //--------------------------------------------------------Exit-------------------------------------
            if(menuInput == "4")
            {
                Console.Clear();
                return;
            }
        }

        //--------------------------------------------------------Other Methods-------------------------------
        public static decimal ViewBalance()
        {
            return Balance;
        }

        public static decimal Withdraw(decimal number)
        {
            if (number > Balance)
            {
                Console.WriteLine("Error: insufficient funds");
                return -1;
            }
            if (number < 0)
            {
                Console.WriteLine("Error: incorrect value");
                return -1;
            }
            Balance -= number;
            Console.WriteLine($"{number} withdrawn.");

            return Balance;
        }

        public static decimal Deposit(decimal number)
        {
            if (number < 0)
            {
                Console.WriteLine("Error: incorrect value");
                return -1;
            }
            Balance += number;
            return Balance;
        }

        public static void ReturnHome()
        {
            Console.WriteLine($"Press 1 to return");
            string userInput = Console.ReadLine();
            while (userInput != "1")
            {
                Console.WriteLine($"Press 1 to return");
                userInput = Console.ReadLine();
            }
            Console.Clear();
            UserInterFace();
        }
    }
}

