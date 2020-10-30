namespace NationalParks.Models
{
  public class Park
  {
    public int ParkId { get; set; }
    public string ParkName { get; set; }
    public string ParkDescription { get; set; }
    public string ParkLocation { get; set; }
    public string DateEstablished { get; set; }
    public decimal ParkArea { get; set; }
    public int AnnualVisitors { get; set; }

  }
}