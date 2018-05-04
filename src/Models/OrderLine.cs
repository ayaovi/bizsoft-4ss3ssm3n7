using System;

namespace bizsoft_4ss3ssm3n7.Models
{
  public class OrderLine
  {
    public Guid Id { get; set; }

    public int Quantity { get; set; }

    public virtual Item Item { get; set; }

    public virtual Order Order { get; set; }
  }
}
