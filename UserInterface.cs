namespace ExpenseTracker;

public static class UserInterface
{
    public static void Run()
    {
        bool isRunning = true;

        while(isRunning)
        {
            Console.WriteLine("\n--- Expense Tracker ---");
            Console.WriteLine("1. Add New Expense");
            Console.WriteLine("2. View All Expenses");
            Console.WriteLine("3. View Total Spend");
            Console.WriteLine("4. Exit");
            Console.Write("Select an option: ");
            string choice = Console.ReadLine() ?? "";

            switch (choice)
            {
                case "1": CreateExpense(); break;
                case "2": ShowExpenses(); break;
                case "3": Console.WriteLine($"Total: £{ExpenseService.GetTotal():N2}"); break;
                case "4": isRunning = false; break;
                default: Console.WriteLine("Invalid choice. Try again."); break;
            }
        }
    }

    private static void CreateExpense()
    {
        string title = GetUserInput("Enter Title: ");
        string category = GetUserInput("Enter Category: ");
        string description = GetUserInput("Enter Description: ");
        decimal amount = GetUserDecimal("Enter Amount: £");
        ExpenseService.AddExpense(title, category, description, amount);
    }
    private static void ShowExpenses(){
        var expenses = ExpenseService.GetAll();
        foreach(var expense in expenses)
        {
            Console.WriteLine($"Title: {expense.Title}, Category: {expense.Category}, Description: {expense.Description}, Amount: £{expense.Amount:N2}, Date: {expense.Date}");
        }
    }

    private static string GetUserInput(string prompt)
    {
        Console.Write(prompt);
        return Console.ReadLine() ?? "";
    }

    private static decimal GetUserDecimal(string prompt)
    {
        Console.Write(prompt);
        string input = Console.ReadLine() ?? "";
        return decimal.TryParse(input, out decimal result) ? result : 0;
    }
}