using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using gregslistcsharp.Models;
using gregslistcsharp.Services;

namespace gregslistcsharp.Controllers
{
  [ApiController]
  [Route("/api/[controller]")]

  public class HousesController : ControllerBase
  {
    private readonly HousesService _housesService;

    public HousesController(HousesService housesService)
    {
      _housesService = housesService;
    }
    [HttpGet]

    //Get all houses
    public ActionResult<IEnumerable<House>> Get()
    {
      try
      {
        IEnumerable<House> houses = _housesService.Get();
        return Ok(houses);
      }
      catch(Exception err)
      {
        return BadRequest(err.Message);
      }
    }
    [HttpGet("{id}")]
    public ActionResult<House> Get(string id)
    {
      try
      {
        House house = _housesService.Get(id);
        return Ok(house);
      }
      catch(Exception err)
      {
        return BadRequest(err.Message);
      }
    }
    [HttpPost]
    public ActionResult<House> Create([FromBody] House newHouse)
    {
      try
      {
        House house = _housesService.Create(newHouse);
        return Ok(house);
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
        _housesService.Delete(id);
        return Ok("Successfully deleted House");
      }
      catch(Exception err)
      {
        return BadRequest(err.Message);
      }
    }
  }
}