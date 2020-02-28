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
  }
}