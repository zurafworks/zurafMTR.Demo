using Core.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class BakimLog : BaseEntity<int>, IEntity
{
    public int VehicleId { get; set; }
    public DateTime BakimDate { get; set; }// bakım tarihi
    public string Summary { get; set; } // yapılan işlemelerin bir özeti.
    public virtual Vehicle Vehicle { get; set; }
}
