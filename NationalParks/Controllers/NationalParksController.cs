using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using NationalParks.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace NationalParks.Controllers
{
  [Authorize]
  [Route("api/[controller]")]
  [ApiController]
  public class NationalParksController : ControllerBase
  {
    private NationalParksContext _db;

    public NationalParksController(NationalParksContext db)
    {
      _db = db;
    }
    
    [HttpGet] 
    public ActionResult<IEnumerable<NationalPark>> Get()
    {
      var query = _db.NationalParks.AsQueryable();     
      return query.ToList();
    }

    [HttpGet("search")] 
    public ActionResult<IEnumerable<NationalPark>> Search(string name, string location, string date)
    {
      var query = _db.NationalParks.AsQueryable();

      if (name != null)
      {
        query = query.Where(entry => entry.NationalParkName.Contains(name));
      }

      if (location != null)
      {
        query = query.Where(entry => entry.NationalParkLocation.Contains(location));
      }

      if (date != null)
      {
        query = query.Where(entry => entry.DateEstablished.Contains(date));
      }
      return query.ToList();
    }

    [HttpGet("{id}")]
    public ActionResult<NationalPark> Get(int id)
    {
      return _db.NationalParks.FirstOrDefault(entry => entry.NationalParkId == id);
    }

    [HttpGet("random")]
    public IEnumerable<NationalPark> Random()
    {
      var count = _db.NationalParks.Count();
      Random ran = new Random();
      int index = ran.Next(count);      
      return _db.NationalParks.OrderBy(r => Guid.NewGuid()).Skip(index).Take(1);      
    }
    
    [HttpPost]
    public void Post([FromBody] NationalPark park)
    {
      _db.NationalParks.Add(park);
      _db.SaveChanges();
    }    
    
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] NationalPark park)
    {
      park.NationalParkId = id;
      _db.Entry(park).State = EntityState.Modified;
      _db.SaveChanges();
    }
   
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var parkToDelete = _db.NationalParks.FirstOrDefault(entry => entry.NationalParkId == id);
      _db.NationalParks.Remove(parkToDelete);
      _db.SaveChanges();
    }    
  }
}