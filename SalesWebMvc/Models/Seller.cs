namespace SalesWebMvc.Models;

public class Seller
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public DateTime DateOfBirth { get; set; }
    public double BaseSalary { get; set; }
    
    public void AddSales(SalesRecord record) {}
    
    public void RemoveSales(SalesRecord record) {}

    public double TotalSales(DateTime startDate, DateTime endDate)
    {
        return 0.0f;
    }

}