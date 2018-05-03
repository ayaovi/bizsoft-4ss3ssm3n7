using System;

namespace bizsoft_4ss3ssm3n7.Models
{
  public class Order
  {
    public Guid Id { get; set; }

    public int ItemId { get; set; }

    public virtual Client Client { get; set; }

    public virtual Item Item { get; set; }

    //public virtual ICollection<Item> StockItems { get; set; }
  }
}