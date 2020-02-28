namespace Models
{
  public class Pastry : Item
  {
    public Pastry()
    {
      Cost = 2;
    }
    public void AddPastries(int numberOfPastries)
    {
      Quantity += numberOfPastries;
    }
    public void CalculateOrder()
    {
      if(Quantity >= 3)
      {
        TotalCost = Quantity % 3 * 2;
        TotalCost += (Quantity / 3) * 5;
      }
      else
      {
        TotalCost = Quantity * Cost;
      }
    }
  }
}