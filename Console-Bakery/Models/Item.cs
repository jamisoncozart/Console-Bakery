namespace Models
{
  public class Item
  {
    public int Cost { get; set; }
    public int Quantity { get; set; } = 0;
    public int TotalCost { get; set; } = 0;

    public void ClearOrder()
    {
      Quantity = 0;
      TotalCost = 0;
    }
  }
}