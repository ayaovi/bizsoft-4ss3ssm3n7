using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace testdata
{
  public class Client
  {
    public string FirstName { get; set; }

    public string LastName { get; set; }

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public virtual ICollection<Order> Orders { get; set; }
  }

  public class Order
  {
    public Guid Id { get; set; }

    public virtual Client Client { get; set; }

    public virtual ICollection<Item> StockItems { get; set; }
  }

  public class Item
  {
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public string Description { get; set; }

    public Material Material { get; set; }
  }

  public class Material
  {
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public string Description { get; set; }
  }
}
