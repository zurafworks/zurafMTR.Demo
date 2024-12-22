using Core.Domain.Abstract;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class Employee : BaseEntity<int>, IEntity
{
    public Title Title { get; set; }// usta çırak kalfa vesaire vesaire babba OK?
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public DateTime HireDate { get; set; }
    public DateTime BirthDate { get; set; }
    public virtual ICollection<IsEmriDetail> IsEmriDetails { get; set; }
}
