namespace ExpenseTracker;

public static class ExpenseService
{
    private static List<Expense> _expenses = new();

    public static void AddExpense(string title, string category, string description, decimal amount)
    {
        _expenses.Add(new Expense(title, category, description, amount, DateTime.Now));
    }

    public static decimal GetTotal() => _expenses.Sum(x => x.Amount);
    
    public static List<Expense> GetAll() => _expenses;
}