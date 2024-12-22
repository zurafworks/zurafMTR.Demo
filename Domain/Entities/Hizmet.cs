using Core.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class Hizmet : BaseEntity<int>, IEntity // ÖRNEK YAĞ DEĞİŞİMİ
{
    public string Name { get; set; }
    public decimal BasePrice { get; set; }
    public string Description { get; set; }
    public virtual ICollection<IsEmriDetail> IsEmriDetails { get; set; }
}
