using Core.Domain.Abstract;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class IsEmri : BaseEntity<int>, IEntity
{
    public int VehicleId { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public Status Status { get; set; }
    public decimal TotalCost { get; set; }
    public virtual Vehicle Vehicle { get; set; }
    public virtual ICollection<IsEmriDetail> IsEmriDetails { get; set; }
    public virtual ICollection<Report> Reports { get; set; }
}
