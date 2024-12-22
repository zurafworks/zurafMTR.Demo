using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Abstract;

public abstract class BaseEntity<TKey>
{
    public virtual TKey Id { get; set; }
    public virtual int UpdateUserId { get; set; }
    public virtual DateTime UpdatedDate { get; set; }
    public virtual bool IsDeleted { get; set; }
}
