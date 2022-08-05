using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Engineer
  {
    public Engineer()
    {
      this.JoinEntities = new HashSet<EngineerMachine>();
    }

    public int EngineerId { get; set; }
    public string Name { get; set; }
    [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
    public DateTime HireDate { get; set;}
    public virtual ICollection<EngineerMachine> JoinEntities { get; set; }
    }
  }
