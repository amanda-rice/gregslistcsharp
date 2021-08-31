using System;
using System.Collections.Generic;
using gregslistcsharp.Models;

namespace gregslistcsharp.Services
{
  public class HousesService
  {
    internal IEnumerable<House> Get()
    {
      return FakeDB.Houses;
    }
    internal House Get(string id)
    {
      House found = FakeDB.Houses.Find(c => c.Id == id);
      if(found == null)
      {
        throw new Exception("Invalid ID");
      }
      return found;
    }
    internal House Create(House newHouse)
    {
      FakeDB.Houses.Add(newHouse);
      return newHouse;
    }

    internal void Delete(string id)
    {
      int deleted = FakeDB.Houses.RemoveAll(c => c.Id == id);
      if(deleted == 0)
      {
      throw new Exception("Invalid ID");
      }
    }
  }
}