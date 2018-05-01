using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace bizsoft_4ss3ssm3n7.Models
{
  public class Client
  {
    public string FirstName { get; set; }

    public string LastName { get; set; }

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public virtual ICollection<Order> Orders { get; set; }
  }
}
