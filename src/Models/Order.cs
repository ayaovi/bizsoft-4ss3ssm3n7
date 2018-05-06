using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace bizsoft_4ss3ssm3n7.Models
{
  [Table("orders")]
  public class Order
  {
    public Guid Id { get; set; }

    public virtual Client Client { get; set; }

    public virtual ICollection<OrderLine> OrderLines { get; set; }
  }
}