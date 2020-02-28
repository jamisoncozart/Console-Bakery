namespace Models
{
  public class Item
  {
    public int Cost { get; set; }
    public int Quantity { get; set; } = 0;
    public int TotalCost { get; set; } = 0;

    public void AddItems(int numberOfItems)
    {
      Quantity += numberOfItems;
    }

    public void ClearOrder()
    {
      Quantity = 0;
      TotalCost = 0;
    }
  }
}