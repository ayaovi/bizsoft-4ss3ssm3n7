using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace bizsoft_4ss3ssm3n7.Models
{
  [Table("orderlines")]
  public class OrderLine
  {
    public Guid Id { get; set; }

    public int Quantity { get; set; }

    public virtual Item Item { get; set; }

    public virtual Order Order { get; set; }
  }
}
