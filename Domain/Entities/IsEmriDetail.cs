using Core.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class IsEmriDetail : BaseEntity<int>, IEntity
{
    public int IsEmriId { get; set; }
    public int HizmetId { get; set; }
    public int EmployeeId { get; set; }
    public decimal Quantity { get; set; }
    public decimal Price { get; set; }// tutar ile alınan para daha farklı olabilir o yüzden iki ayrı alan babba OK?
    public virtual IsEmri IsEmri { get; set; }
    public virtual Hizmet Hizmet { get; set; }
    public virtual Employee Employee { get; set; }
}
