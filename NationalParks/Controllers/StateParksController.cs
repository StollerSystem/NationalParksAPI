using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using NationalParks.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace StateParks.Controllers
{
  [Authorize]
  [Route("api/[controller]")]
  [ApiController]
  public class StateParksController : ControllerBase
  {
    private NationalParksContext _db;

    public StateParksController(NationalParksContext db)
    {
      _db = db;
    }
    
    [HttpGet] 
    public ActionResult<IEnumerable<StatePark>> Get(string name, string state) 
    {
      var query = _db.StateParks.AsQueryable();

      if (name != null)
      {
        query = query.Where(entry => entry.StateParkName == name);
      }

      if (state != null)
      {
        query = query.Where(entry => entry.State == state);
      }
      return query.ToList();
    }

    [HttpGet("{id}")]
    public ActionResult<StatePark> Get(int id)
    {
      return _db.StateParks.FirstOrDefault(entry => entry.StateParkId == id);
    }

    [HttpGet("Random")]
    public IEnumerable<StatePark> Random()
    {
      var count = _db.StateParks.Count();
      Random ran = new Random();
      int index = ran.Next(count);      
      return _db.StateParks.OrderBy(r => Guid.NewGuid()).Skip(index).Take(1);      
    }
    
    [HttpPost]
    public void Post([FromBody] StatePark park)
    {
      _db.StateParks.Add(park);
      _db.SaveChanges();
    }    
    
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] StatePark park)
    {
      park.StateParkId = id;
      _db.Entry(park).State = EntityState.Modified;
      _db.SaveChanges();
    }
   
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var parkToDelete = _db.StateParks.FirstOrDefault(entry => entry.StateParkId == id);
      _db.StateParks.Remove(parkToDelete);
      _db.SaveChanges();
    }
  }
}