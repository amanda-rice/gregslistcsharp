using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace gregslistcsharp.Models
{
  public class Job
  {
    public string Id { get; set; }
    [Required]
    [Range(1, 200)]
    public int Rate{ get; set; }
    [Required]
    [MinLength(3)]
    [MaxLength(20)]
    public string JobTitle{ get; set; }
    [Required]
    [Range(0, 100)]
    public int Hours{ get; set; }
    [Required]
    [MinLength(3)]
    [MaxLength(500)]
    public string Description{ get; set; }
    [Required]
    [MinLength(3)]
    [MaxLength(20)]
    public string Company{ get; set; }
    public Job(int rate, string jobTitle, int hours, string description, string company){
      Rate = rate;
      JobTitle = jobTitle;
      Hours = hours;
      Description = description;
      Company = company;
      Id = Guid.NewGuid().ToString();
    }
  }
}