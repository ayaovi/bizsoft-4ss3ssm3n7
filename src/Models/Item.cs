﻿using System.ComponentModel.DataAnnotations.Schema;

namespace bizsoft_4ss3ssm3n7.Models
{
  public class Item
  {
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public string Description { get; set; }

    public Material Material { get; set; }
  }
}