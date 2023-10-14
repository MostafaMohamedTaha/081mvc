using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace coreEfMvc.Models;

[Table("Customer")]
public partial class Customer
{
    [Key]
    public int Id { get; set; }

    [StringLength(70)]
    public string? FirstName { get; set; }

    [StringLength(70)]
    public string? LastName { get; set; }

    [StringLength(500)]
    public string? ImageUrl { get; set; }
}
