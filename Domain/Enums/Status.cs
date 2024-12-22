using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enums;
/// <summary>
/// İŞ EMRİNİN DURUMU
/// </summary>
public enum Status
{
    Beklemede = 0,
    İşlemde,
    Tamamlandı,
    Iptal
}
