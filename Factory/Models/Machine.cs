using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Machine
  {
    public Machine()
{
      this.JoinEntities = new HashSet<EngineerMachine>();
    }

    public int MachineId { get; set; }
    public string Description { get; set; }
    [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
    public DateTime InstallDate { get; set;}

    public virtual ICollection<EngineerMachine> JoinEntities { get;}
  }
}