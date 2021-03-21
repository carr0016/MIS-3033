using System;
using System.Collections.Generic;

namespace Exam1_Practicing
{
    class Program
    {
        static void Main(string[] args)
        {


            Dictionary<int, List<Receipt>> receipts = new Dictionary<int, List<Receipt>>();
            string answer;


            do
            {

                int cogs = ValidateIntegerInput("Enter the quantity of cogs >>", "Sorry that it is invalid. Please try again.");
                int gears = ValidateIntegerInput("Enter the quantity of gears >>", "Sorry that it is invalid. Please try again.");
                int id = ValidateIntegerInput("Enter the customer's ID >>", "Sorry that it is invalid. Please try again.");

                Receipt receipt = new Receipt(id, cogs, gears);

                if (receipts.ContainsKey(id) == false)
                {
                    receipts.Add(id, new List<Receipt>());
                }

                receipts[id].Add(receipt);

                Console.WriteLine("Do you want to enter information for another receipt? (Yes,No)");
                answer = Console.ReadLine();

            } while (answer.ToLower() == "yes");

            do
            {
                DisplayOptions();
                answer = Console.ReadLine();
                int choice = 0;
                while (int.TryParse(answer, out choice) == false | (choice != 3 && choice != 2 && choice != 1))
                {
                    Console.WriteLine($"(answer) was not a valid input. Please look at the menu and try again");
                    DisplayOptions();
                    answer = Console.ReadLine();
                }
                switch (choice)
                {
                    case 1:
                        int id = ValidateIntegerInput("Please enter the customer id that you want to see receipts from >>", "Sorry that was not a valid ID. Enter an actual customer ID")
                        DisplayReceiptsByCustomerID(receipts, id);
                        break;
                    case 2:
                        DisplayReceiptsForToday(receipts);
                        break;

                    case 3:
                        DisplayReceiptsWithHighestTotal(receipts);
                        break;
                }


                Console.WriteLine("Do you want to display more reciepts? (Yes or No)");
                answer = Console.ReadLine();

            } while (answer.ToLower() == "yes");

            Console.WriteLine("Bye");
        }

        private static void DisplayReceiptsWithHighestTotal(Dictionary<int, List<Receipt>> receipts)
        {
            double highest = -1;
            foreach (var customer in receipts.Keys)
            {
                foreach (var receipt in receipts[customer])
                {
                    if (receipt.CalculateTotal() > highest)
                    {
                        highest = receipt.CalculateTotal();
                    }
                }
            }
            foreach (var customer in receipts.Keys)
            {
                foreach (var receipt in receipts[customer])
                {
                    if (receipt.CalculateTotal() == highest)
                    {
                        receipt.PrintReceipt();
                    }
                }
            }
        }

        private static void DisplayReceiptsForToday(Dictionary<int, List<Receipt>> receipts)
        {
            foreach (var customer in receipts.Keys)
            {
                foreach (var receipt in receipts[customer])
                {
                    if (receipt.SaleDate.Date == DateTime.Now.Date)
                    {
                        receipt.PrintReceipt();
                    }
                }
            }
        }

        private static void DisplayReceiptsByCustomerID(Dictionary<int, List<Receipt>> receipts, int id)
        {
            foreach (var receipt in receipts[id])
            {
                receipt.PrintReceipt();
            }
        }

        private static void DisplayOptions()
        {
            Console.WriteLine("".PadRight(15, '$'));
            Console.WriteLine("\tOptions");
            Console.WriteLine("1. By Customer ID");
            Console.WriteLine("2. All of todays Receipt's");
            Console.WriteLine("3. Receipt with highest total");
            Console.WriteLine("".PadRight(15, '#'));
            Console.WriteLine();
        }

        private static int ValidateIntegerInput(string initialMessage, string repromptMessage)
        {
            int value;
            string input;
            Console.WriteLine(initialMessage);
            input = Console.ReadLine();
            while (int.TryParse(input, out value) == false)
            {
                Console.WriteLine(repromptMessage);
                input = Console.ReadLine();
            }

            return value;

        }
    }
}






        }
    }
}
