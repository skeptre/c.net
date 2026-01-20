namespace ExpenseTracker;

public class Expense (string title, string category, string description, decimal amount, DateTime date)
{
    public string Title { get; set; } = title;
    public string Category { get; set; } = category;
    public string Description { get; set; } = description;
    public decimal Amount { get; set; } = amount;
    public DateTime Date { get; set; } = date;
}