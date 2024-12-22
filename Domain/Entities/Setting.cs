using Core.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
/// <summary>
/// MURAT
/// </summary>
public class Setting : BaseEntity<int>, IEntity
{
    public string Key { get; set; }// tax rate falan eklerken tüm ayarları key value olarak tuttum
    public string Value { get; set; }
}
