using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using gregslistcsharp.Models;
using gregslistcsharp.Services;

namespace gregslistcsharp.Controllers
{
  [ApiController]
  [Route("/api/[controller]")]

  public class JobsController : ControllerBase
  {
    private readonly JobsService _jobsService;

    public JobsController(JobsService jobsService)
    {
      _jobsService = jobsService;
    }
    [HttpGet]

    //Get all jobs
    public ActionResult<IEnumerable<Job>> Get()
    {
      try
      {
        IEnumerable<Job> jobs = _jobsService.Get();
        return Ok(jobs);
      }
      catch(Exception err)
      {
        return BadRequest(err.Message);
      }
    }
    [HttpGet("{id}")]
    public ActionResult<Job> Get(string id)
    {
      try
      {
        Job job = _jobsService.Get(id);
        return Ok(job);
      }
      catch(Exception err)
      {
        return BadRequest(err.Message);
      }
    }
    [HttpPost]
    public ActionResult<Job> Create([FromBody] Job newJob)
    {
      try
      {
        Job job = _jobsService.Create(newJob);
        return Ok(job);
      }
      catch (Exception err)
      {
        return BadRequest(err.Message);
      }
    }
    [HttpDelete("{id}")]
    public ActionResult<String> Delete(string id)
    {
      try
      {
        _jobsService.Delete(id);
        return Ok("Successfully deleted Job");
      }
      catch(Exception err)
      {
        return BadRequest(err.Message);
      }
    }
  }
}