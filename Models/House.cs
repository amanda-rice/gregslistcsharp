using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace gregslistcsharp.Models
{
  public class House
  {
    public string Id { get; set; }
    [Required]
    [Range(1, 20)]
    public int Levels{ get; set; }
    [Required]
    [Range(1, 20)]
    public int Bathrooms{ get; set; }
    [Required]
    [Range(1000, 1000000000)]
    public int Price{ get; set; }
    [Required]
    [Range(0, 50)]
    public int Bedrooms{ get; set; }
    [Required]
    [Range(1000, 2021)]
    public int Year{ get; set; }
    [Required]
    [MinLength(3)]
    [MaxLength(500)]
    public string ImgUrl { get; set; }
    // public List<string> Pictures{ get; set; }
    //List<string> pictures
    public House(int levels, int bathrooms, int price, int bedrooms, int year, string imgUrl){
      Levels = levels;
      Bathrooms = bathrooms;
      Price = price;
      Bedrooms = bedrooms;
      Year = year;
      ImgUrl = imgUrl;
      // Pictures = pictures;
      Id = Guid.NewGuid().ToString();
    }
  }
}