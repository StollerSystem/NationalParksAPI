using System.ComponentModel.DataAnnotations;

namespace NationalParks.Models
{
  public class StatePark
  {
    public int StateParkId { get; set; }
    [Required]
    public string StateParkName { get; set; }
    [Required]
    public string StateParkDescription { get; set; }
    [Required]
    public string State { get; set; }    

    public bool YearRound { get; set; } 
  }
}