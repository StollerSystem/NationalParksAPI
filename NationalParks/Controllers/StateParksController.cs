// using System.Collections.Generic;
// using System.Linq;
// using Microsoft.AspNetCore.Mvc;
// using NationalParks.Models;
// using Microsoft.EntityFrameworkCore;
// using Microsoft.AspNetCore.Authorization;

// namespace StateParks.Controllers
// {
//   [Authorize]
//   [Route("api/[controller]")]
//   [ApiController]
//   public class StateParksController : ControllerBase
//   {
//     private NationalParksContext _db;

//     public StateParksController(NationalParksContext db)
//     {
//       _db = db;
//     }

    
//     [HttpGet] 
//     public ActionResult<IEnumerable<StatePark>> Get(string name, string location) //ADD MORE!
//     {
//       var query = _db.StateParks.AsQueryable();

//       if (name != null)
//       {
//         query = query.Where(entry => entry.ParkName == name);
//       }

//       if (location != null)
//       {
//         query = query.Where(entry => entry.ParkLocation == location);
//       }
      

//       return query.ToList();
//     }

    
//     [HttpPost]
//     public void Post([FromBody] StatePark park)
//     {
//       _db.StateParks.Add(park);
//       _db.SaveChanges();
//     }
    
//     [HttpGet("{id}")]
//     public ActionResult<StatePark> Get(int id)
//     {
//       return _db.StateParks.FirstOrDefault(entry => entry.ParkId == id);
//     }
    
//     [HttpPut("{id}")]
//     public void Put(int id, [FromBody] StatePark park)
//     {
//       park.ParkId = id;
//       _db.Entry(park).State = EntityState.Modified;
//       _db.SaveChanges();
//     }
   
//     [HttpDelete("{id}")]
//     public void Delete(int id)
//     {
//       var parkToDelete = _db.StateParks.FirstOrDefault(entry => entry.ParkId == id);
//       _db.StateParks.Remove(parkToDelete);
//       _db.SaveChanges();
//     }
//   }
// }