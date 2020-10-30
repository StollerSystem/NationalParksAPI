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
    public ActionResult<IEnumerable<NationalPark>> Get(string name, string location) //ADD MORE!
    {
      var query = _db.NationalParks.AsQueryable();

      if (name != null)
      {
        query = query.Where(entry => entry.ParkName == name);
      }

      if (location != null)
      {
        query = query.Where(entry => entry.ParkLocation == location);
      }
      

      return query.ToList();
    }

    
    [HttpPost]
    public void Post([FromBody] NationalPark park)
    {
      _db.NationalParks.Add(park);
      _db.SaveChanges();
    }
    
    [HttpGet("{id}")]
    public ActionResult<NationalPark> Get(int id)
    {
      return _db.NationalParks.FirstOrDefault(entry => entry.ParkId == id);
    }
    
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] NationalPark park)
    {
      park.ParkId = id;
      _db.Entry(park).State = EntityState.Modified;
      _db.SaveChanges();
    }
   
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var parkToDelete = _db.NationalParks.FirstOrDefault(entry => entry.arkId == id);
      _db.NationalParks.Remove(parkToDelete);
      _db.SaveChanges();
    }
  }
}