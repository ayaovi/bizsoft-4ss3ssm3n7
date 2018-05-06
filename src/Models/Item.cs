using System.ComponentModel.DataAnnotations.Schema;

namespace bizsoft_4ss3ssm3n7.Models
{
  [Table("items")]
  public class Item
  {
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public string Description { get; set; }

    public virtual Material Material { get; set; }
  }
}