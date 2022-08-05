namespace ProjectName.Models
{
  public class MachineEngineer
  {       
    public int EngineerItemId { get; set; }
    public int MachineId { get; set; }
    public int EngineerMachine { get; set; }
    public virtual Engineer Engineer { get; set; }
    public virtual Machine Machine { get; set; }
  }
}