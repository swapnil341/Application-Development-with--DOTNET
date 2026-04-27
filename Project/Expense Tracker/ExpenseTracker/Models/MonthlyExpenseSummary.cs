namespace ExpenseTracker.Models
{
    public class MonthlyExpenseSummary
    {
        public string Month { get; set; } = string.Empty;
        public decimal TotalAmount { get; set; }
    }
}