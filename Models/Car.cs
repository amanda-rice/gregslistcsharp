using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace gregslistcsharp.Models
{
  public class Car
  {
    public string Id { get; set; }
    [Required]
    [MinLength(3)]
    [MaxLength(20)]
    public string Make{ get; set; }
    [Required]
    [MinLength(3)]
    [MaxLength(20)]
    public string Model{ get; set; }
    [Required]
    [Range(1886, 2022)]
    public int Year{ get; set; }
    [Required]
    [Range(0, 100000000)]
    public double Price{ get; set; }
    [Required]
    [MinLength(3)]
    [MaxLength(500)]
    public string Description{ get; set; }
    [Required]
    [MinLength(3)]
    [MaxLength(500)]
    public string ImgUrl { get; set; }
    // public List<string> Pictures{ get; set; }
    //List<string> pictures
    public Car(string make, string model, int year, double price, string description, string imgUrl){
      Make = make;
      Model = model;
      Year = year;
      Price = price;
      Description = description;
      ImgUrl = imgUrl;
      // Pictures = pictures;
      Id = Guid.NewGuid().ToString();
    }
  }
}