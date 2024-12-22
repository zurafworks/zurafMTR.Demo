using Core.Persistance.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistance.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories.Concrete.EntityFramework;

public class SettingRepository : Repository<Setting>, ISettingRepository
{
    public SettingRepository(DbContext context) : base(context)
    {
    }
}
