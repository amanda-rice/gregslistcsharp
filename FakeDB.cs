using System.Collections.Generic;
using gregslistcsharp.Models;

namespace gregslistcsharp
{
  static public class FakeDB
  {
    static public List<Car> Cars { get; set; } = new List<Car>() { new Car("Toyota", "Corolla", 2004, 2000.03, "really cool", "https://www.google.com/url?sa=i&url=https%3A%2F%2Fen.wikipedia.org%2Fwiki%2FToyota_Corolla_(E120)&psig=AOvVaw1qz24F_0FaVTagjThUf3V6&ust=1630527937832000&source=images&cd=vfe&ved=0CAgQjRxqFwoTCMD8woaM3PICFQAAAAAdAAAAABAD" ) };
    static public List<House> Houses { get; set; } = new List<House>() { new House(3, 3, 350000, 3, 2000, "https://th.bing.com/th/id/OIP.rDuihvrXX3lwRL9aXNafHgHaKN?pid=ImgDet&rs=1" ) };
    static public List<Job> Jobs { get; set; } = new List<Job>() { new Job(30, "Cashier", 40, "do some stuff", "Albertsons") };
  }
}