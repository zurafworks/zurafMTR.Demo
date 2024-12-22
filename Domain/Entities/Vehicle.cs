using Core.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class Vehicle : BaseEntity<int>, IEntity
{
    public int CustomerId { get; set; }// araç hangi müşteriye ait
    public string Plate { get; set; }// aracın plakası
    public string SasiNo { get; set; }
    public string Marka { get; set; }
    public string Model { get; set; }
    public string Year { get; set; }// aracın yılı
    public string Color { get; set; } // gerekli mi düşünülecek.
    public virtual Customer Customer { get; set; }
    public virtual ICollection<BakimLog> Bakims { get; set; }
    public virtual ICollection<IsEmri> IsEmris { get; set; }
}
