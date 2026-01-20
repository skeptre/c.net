namespace ExpenseTracker;

public static class ExpenseService
{
    private static List<Expense> _expenses = new();

    public static void AddExpense(string t, string c,string d, decimal a, DateTime date)
    {
        _expenses.Add(new Expense(t, c, d, a, date));
    }

    public static decimal GetTotal() => _expenses.Sum(x => x.Amount);
    
    public static List<Expense> GetAll() => _expenses;
}