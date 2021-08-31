using System;
using System.Collections.Generic;
using gregslistcsharp.Models;

namespace gregslistcsharp.Services
{
  public class JobsService
  {
    internal IEnumerable<Job> Get()
    {
      return FakeDB.Jobs;
    }
    internal Job Get(string id)
    {
      Job found = FakeDB.Jobs.Find(c => c.Id == id);
      if(found == null)
      {
        throw new Exception("Invalid ID");
      }
      return found;
    }
    internal Job Create(Job newJob)
    {
      FakeDB.Jobs.Add(newJob);
      return newJob;
    }

    internal void Delete(string id)
    {
      int deleted = FakeDB.Jobs.RemoveAll(c => c.Id == id);
      if(deleted == 0)
      {
      throw new Exception("Invalid ID");
      }
    }
  }
}