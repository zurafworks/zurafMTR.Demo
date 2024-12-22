using Core.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class Report : BaseEntity<int>, IEntity
{
    public int IsEmriId { get; set; }
    public string Path { get; set; }// PDF PATHI
    public DateTime CreatedDate { get; set; }
    public virtual IsEmri IsEmri { get; set; }
}
