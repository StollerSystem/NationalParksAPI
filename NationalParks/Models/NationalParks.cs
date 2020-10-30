using System.ComponentModel.DataAnnotations;

namespace NationalParks.Models
{
  public class NationalPark
  {
    public int NationalParkId { get; set; }
    [Required]
    public string NationalParkName { get; set; }
    [Required]
    public string NationalParkDescription { get; set; }
    [Required]
    public string NationalParkLocation { get; set; }
    [Required]
    public string DateEstablished { get; set; }
    [Required]
    public double NationalParkArea { get; set; }
    
    public int AnnualVisitors { get; set; }

  }
}