using System.ComponentModel.DataAnnotations;

namespace NationalParks.Models
{
  public class Park
  {
    public int ParkId { get; set; }
    [Required]
    public string ParkName { get; set; }
    [Required]
    public string ParkDescription { get; set; }
    [Required]
    public string ParkLocation { get; set; }
    [Required]
    public string DateEstablished { get; set; }
    [Required]
    public double ParkArea { get; set; }
    
    public int AnnualVisitors { get; set; }

  }
}