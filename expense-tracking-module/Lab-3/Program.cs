using System;
using System.Collections.Generic;

namespace ExpenseTracker
{
    // Expense Class
    class Expense
    {
        public string Category { get; set; }
        public double Amount { get; set; }

        public Expense(string category, double amount)
        {
            Category = category;
            Amount = amount;
        }
    }

    // Custom Exception
    class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException(string message) : base(message)
        {
        }
    }

    class Program
    {
        static List<Expense> expenses = new List<Expense>();

        static double income;
        static double totalExpense = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("========== EXPENSE TRACKER ==========\n");

            // Ask Income Only Once
            while (true)
            {
                try
                {
                    Console.Write("Enter Monthly Income: Rs.");
                    income = Convert.ToDouble(Console.ReadLine());

                    if (income <= 0)
                        throw new Exception("Income must be greater than zero.");

                    Console.WriteLine("\nIncome saved successfully!\n");
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a valid numeric income.\n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + "\n");
                }
            }

            int choice;

            do
            {
                Console.WriteLine("\n========== MENU ==========");
                Console.WriteLine("1. Add Expense");
                Console.WriteLine("2. View Expenses");
                Console.WriteLine("3. View Summary");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            AddExpense();
                            break;

                        case 2:
                            ViewExpenses();
                            break;

                        case 3:
                            ShowSummary();
                            break;

                        case 4:
                            Console.WriteLine("\nThank you for using Expense Tracker!");
                            break;

                        default:
                            Console.WriteLine("Please enter a valid choice (1-4).");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter numbers only.");
                    choice = 0;
                }

            } while (choice != 4);
        }

        // Add Expense
        static void AddExpense()
        {
            try
            {
                Console.Write("Enter Expense Category: ");
                string category = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(category))
                    throw new Exception("Category cannot be empty.");

                Console.Write("Enter Expense Amount: Rs.");
                double amount = Convert.ToDouble(Console.ReadLine());

                if (amount <= 0)
                    throw new Exception("Expense amount must be greater than zero.");

                if (totalExpense + amount > income)
                    throw new InsufficientBalanceException(
                        "Expense exceeds your remaining balance!"
                    );

                expenses.Add(new Expense(category, amount));
                totalExpense += amount;

                Console.WriteLine("\nExpense added successfully.");
                Console.WriteLine("Remaining Balance: Rs." + (income - totalExpense));
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid amount.");
            }
            catch (InsufficientBalanceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // View Expenses
        static void ViewExpenses()
        {
            if (expenses.Count == 0)
            {
                Console.WriteLine("\nNo expenses recorded.");
                return;
            }

            Console.WriteLine("\n========== EXPENSE LIST ==========");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("{0,-20}{1,10}", "Category", "Amount");
            Console.WriteLine("-------------------------------");

            foreach (Expense expense in expenses)
            {
                Console.WriteLine("{0,-20}{1,10}", expense.Category, expense.Amount);
            }
        }

        // Summary
        static void ShowSummary()
        {
            Console.WriteLine("\n========== SUMMARY ==========");
            Console.WriteLine("Monthly Income    : Rs." + income);
            Console.WriteLine("Total Expenses    : Rs." + totalExpense);
            Console.WriteLine("Remaining Balance : Rs." + (income - totalExpense));
        }
    }
}