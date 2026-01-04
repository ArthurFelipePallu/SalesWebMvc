namespace SalesWebMvc.Models;

public class Department
{
   public int Id { get; set; }
   public string Name { get; set; }

   public void AddSeller(Seller seller)
   {
      
   }

   public double GetTotalSales(DateTime startDate, DateTime endDate)
   {
      return 0.0f;
   }
    
}