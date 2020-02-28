namespace Models
{
  public class Bread : Item
  {
    public Bread()
    {
      Cost = 5;
    }
    public void AddBread(int numberOfBreads)
    {
      Quantity += numberOfBreads;
    }
    public void CalculateOrder()
    {
      TotalCost = Quantity * Cost;
      Quantity += Quantity/2;
    }
  }
}